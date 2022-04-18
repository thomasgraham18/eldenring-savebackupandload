using EldenRingSaveCopy;
using EldenRingSaveCopy.Saves.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eldenringsavebackup
{
    public partial class ERSaveLoader : Form
    {
        string userPath;
        string backupPath;

        private FileManager _fileManager;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private BindingList<ISaveGame> sourceSaveGames = new BindingList<ISaveGame>();
        private BindingList<ISaveGame> targetSaveGames = new BindingList<ISaveGame>();

        private ISaveGame selectedSourceSave = new NullSaveGame();
        private ISaveGame selectedTargetSave = new NullSaveGame();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region SaveCopy Code

        private void CheckButtonState()
        {
                btnCopy.Text = "Copy";
                if (_fileManager.SourceFile.Length > 0 && _fileManager.TargetFile.Length > 0
                    && _fileManager.SourcePath != _fileManager.TargetPath &&
                    this.selectedSourceSave.Id != Guid.Empty && this.selectedTargetSave.Id != Guid.Empty)
                {
                    btnCopy.Enabled = true;
                    // btnCopy.BackColor = Color.Lime;
                }
                else
                {
                    btnCopy.Enabled = false;
                    //btnCopy.BackColor = Color.SeaGreen;
                }

        }

        private void cboFromSaveSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ComboBox = (ComboBox)sender;
            this.selectedSourceSave = (ISaveGame)ComboBox.SelectedItem;
            CheckButtonState();
        }

        private void cboToSaveSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ComboBox = (ComboBox)sender;
            this.selectedTargetSave = (ISaveGame)ComboBox.SelectedItem;
            CheckButtonState();
        }

        private void CreateFileBackup(string path, byte[] file)
        {
            int backupCount = 2;
            string backupPath = path.Replace("ER0000.sl2", "ER0000.backup1");
            while (File.Exists(backupPath))
            {
                backupPath = backupPath.Remove(backupPath.Length - 1, 1) + $"{backupCount}";
                backupCount++;
            }
            File.WriteAllBytes(backupPath, file);
        }

        private int SlotStartIndex(SaveGame save)
        {
            return (SaveGame.SLOT_START_INDEX + (save.Index * 0x10) + (save.Index * SaveGame.SLOT_LENGTH));
        }

        private int HeaderStartIndex(SaveGame save)
        {
            return (SaveGame.SAVE_HEADER_START_INDEX + (save.Index * SaveGame.SAVE_HEADER_LENGTH));
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                CreateFileBackup(_fileManager.TargetPath, _fileManager.TargetFile);

                var sourceSave = (SaveGame)this.selectedSourceSave;
                var targetSave = (SaveGame)this.selectedTargetSave;
                byte[] newSave = new byte[_fileManager.TargetFile.Length];

                //Create temp working file
                Array.Copy(_fileManager.TargetFile, newSave, _fileManager.TargetFile.Length);

                //Replace steam id in the source save with the steam id of the target save
                foreach (int idLocation in sourceSave.SaveData.StartingIndex(_fileManager.SourceID))
                {
                    Array.Copy(_fileManager.TargetID, 0, sourceSave.SaveData, idLocation, _fileManager.TargetID.Length);
                }

                //Copy source save slot to target save slot in temp file
                Array.Copy(sourceSave.SaveData, 0, newSave, SlotStartIndex(targetSave), SaveGame.SLOT_LENGTH);

                //Copy save header to temp file
                Array.Copy(sourceSave.HeaderData, 0, newSave, HeaderStartIndex(targetSave), SaveGame.SAVE_HEADER_LENGTH);

                //Mark target slot as active
                newSave[SaveGame.CHAR_ACTIVE_STATUS_START_INDEX + targetSave.Index] = 0x01;

                //Calculate checksums
                using (var md5 = MD5.Create())
                {
                    //Get slot checksum
                    md5.ComputeHash(sourceSave.SaveData);
                    //Write checksum to temp target file
                    Array.Copy(md5.Hash, 0, newSave, SlotStartIndex(targetSave) - 0x10, 0x10);
                    //get header checksum
                    md5.ComputeHash(newSave.Skip(SaveGame.SAVE_HEADERS_SECTION_START_INDEX).Take(SaveGame.SAVE_HEADERS_SECTION_LENGTH).ToArray());
                    //Write headers checksum
                    Array.Copy(md5.Hash, 0, newSave, SaveGame.SAVE_HEADERS_SECTION_START_INDEX - 0x10, 0x10);
                }



                //Write temp file to target file
                File.WriteAllBytes(_fileManager.TargetPath, newSave);

                //Delete old backup file to avoid corrupt save error
                File.Delete(_fileManager.TargetPath + ".bak");

                this.targetSaveGames.RemoveAt(targetSave.Index);
                this.targetSaveGames.Insert(sourceSave.Index, sourceSave);
                cboToSaveSlot.SelectedIndex = targetSave.Index;

                //Indicate successful copy

                btnCopy.Text = "Complete";
            }
            catch (Exception _e)
            {

                btnCopy.Text = "Failed";

                byte[] err = Encoding.Default.GetBytes(_e.Message);
                File.WriteAllBytes(_fileManager.TargetPath.Replace("ER0000.sl2", "Error.log"), err);
            }

        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            sourceSaveGames.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Elden Ring Save File |ER0000.sl2";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                _fileManager.SourcePath = openFileDialog.FileName;
                try
                {
                    _fileManager.SourceFile = File.ReadAllBytes(_fileManager.SourcePath);
                    txtSourceFile.Text = _fileManager.SourcePath;

                    for (int i = 0; i < 10; i++)
                    {
                        var newSave = new SaveGame();
                        newSave.LoadData(_fileManager.SourceFile, i);
                        if (newSave.Active)
                        {
                            sourceSaveGames.Add(newSave);
                        }
                    }
                }
                catch (IOException)
                {
                    txtSourceFile.Text = "Failed to load";
                }
            }
            CheckButtonState();
        }

        private void btnDestFile_Click(object sender, EventArgs e)
        {
            targetSaveGames.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Elden Ring Save File |ER0000.sl2";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _fileManager.TargetPath = openFileDialog.FileName;
                try
                {
                    _fileManager.TargetFile = File.ReadAllBytes(_fileManager.TargetPath);
                    txtDestFile.Text = _fileManager.TargetPath;

                    for (int i = 0; i < 10; i++)
                    {
                        var newSave = new SaveGame();
                        newSave.LoadData(_fileManager.TargetFile, i);
                        if (!newSave.Active)
                        {
                            newSave.CharacterName = $"Slot {i + 1}";
                        }
                        targetSaveGames.Add(newSave);
                    }
                }
                catch (IOException)
                {
                    txtSourceFile.Text = "Failed to load";
                }
            }
            CheckButtonState();
        }


        #endregion
        public ERSaveLoader()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(90, Color.Black);
            panel2.BackColor = Color.FromArgb(90, Color.Black);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            // Using user set path to set variables to correct file location
            string sourceFile1 = $"{userPath}\\ER0000.sl2";
            string sourceFile2 = $"{userPath}\\ER0000.sl2.bak";
            string sourceFile3 = $"{userPath}\\steam_autocloud.vdf";
            string destinationFile1 = $"{backupPath}\\ER0000.sl2";
            string destinationFile2 = $"{backupPath}\\ER0000.sl2.bak";
            string destinationFile3 = $"{backupPath}\\steam_autocloud.vdf";

            // Try copying the files
            try
            {
                File.Copy(sourceFile1, destinationFile1, true);
                File.Copy(sourceFile2, destinationFile2, true);
                File.Copy(sourceFile3, destinationFile3, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

            lblBackupStatus.Text = "Save backed up";
            Wait(10000);
            lblBackupStatus.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Using user set path to set variables to correct file location
            string sourceFile1 = $"{backupPath}\\ER0000.sl2";
            string sourceFile2 = $"{backupPath}\\ER0000.sl2.bak";
            string sourceFile3 = $"{backupPath}\\steam_autocloud.vdf";
            string destinationFile1 = $"{userPath}\\ER0000.sl2";
            string destinationFile2 = $"{userPath}\\ER0000.sl2.bak";
            string destinationFile3 = $"{userPath}\\steam_autocloud.vdf";

            // Try copying the files
            try
            {
                File.Copy(sourceFile1, destinationFile1, true);
                File.Copy(sourceFile2, destinationFile2, true);
                File.Copy(sourceFile3, destinationFile3, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

            lblBackupStatus.Text = "Loaded backed up save";
            Wait(10000);
            lblBackupStatus.Text = "";
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            // Set root folder as %appdata% & show the choose folder dialog
            fbdSave.RootFolder = Environment.SpecialFolder.ApplicationData; 
            fbdSave.ShowDialog(); 

            // Set global variable as user selected location
            userPath = fbdSave.SelectedPath; 

            // Set buttons to guide user to choose backup location
            btnBackupLocation.Enabled = true;
            btnSaveLocation.Enabled = false;

            // Save user selected location, so they dont have to choose over and over
            Properties.Settings.Default.SaveLocation = userPath;
            Properties.Settings.Default.Save();

            // Change label to user selected path
            txtSaveLocation.Text = userPath;
        }

        private void btnBackupLocation_Click(object sender, EventArgs e)
        {
            // Set root folder as %appdata% & show the choose folder dialog
            fbdBackup.RootFolder = Environment.SpecialFolder.ApplicationData;
            fbdBackup.ShowDialog();

            // If user has selected the same path for backup as save, first: let them know, second: stop them.
            if(fbdBackup.SelectedPath == fbdSave.SelectedPath)
            {
                MessageBox.Show("Please choose/create a folder for BACKUPS, you selected your save folder twice");
                return;
            }

            // Set global variable as user selected location
            backupPath = fbdBackup.SelectedPath;

            // Set all buttons to enabled to give user full functionality
            btnBackup.Enabled = true;
            btnLoad.Enabled = true;
            btnSaveLocation.Enabled = true;

            // Save user selected location, so they dont have to choose over and over
            Properties.Settings.Default.BackupLocation = backupPath;
            Properties.Settings.Default.Save();

            // Change label to user selected path
            txtBackupLocation.Text = backupPath;

            // Change label to let user know information has been saved
            lblLocation.Text = "Save and backup location stored and ready for use";

        }

        private void ERSaveLoader_Load(object sender, EventArgs e)
        {
            _fileManager = new FileManager();

            cboFromSaveSlot.DisplayMember = "CharacterName";
            //cboFromSaveSlot.DataSource = this.sourceSaveGames;
            cboFromSaveSlot.DataSource = new BindingSource() { DataSource = this.sourceSaveGames }.DataSource;
            cboToSaveSlot.DisplayMember = "CharacterName";
            //cboToSaveSlot.DataSource = this.targetSaveGames;
            cboToSaveSlot.DataSource = new BindingSource() { DataSource = this.targetSaveGames }.DataSource;


            //Usefull for debugging
            //Properties.Settings.Default.Reset(); 

            //Set lbl default txt
            lblLocation.Text = "Please choose your save and backup location!";

            // Check if user settings are empty, if so return program to normal state, if not, set global variables as stored paths @Credits to Jacques
            if (Properties.Settings.Default.SaveLocation != "")
            {
                userPath = Properties.Settings.Default.SaveLocation;
            }
            else
            {
                return;
            }
            if (Properties.Settings.Default.BackupLocation != "")
            {
                backupPath = Properties.Settings.Default.BackupLocation;
            }
            else
            {
                return;
            }

            //Change to text to show user saved paths
            txtBackupLocation.Text = backupPath;
            txtSaveLocation.Text = userPath;

            // If user has stored paths, set all buttons to enabled to give user full functionality
            btnBackup.Enabled = true;
            btnLoad.Enabled = true;
            btnBackupLocation.Enabled = true;
            btnSaveLocation.Enabled = true;

            // Set lbl to tell user saved are locations are ready for use
            lblLocation.Text = "Save and backup location stored and ready for use";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ERSaveLoader_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlTitle_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void Wait(int milliseconds)
        {
            var myTimer = new System.Windows.Forms.Timer(); // Create a system timer

            myTimer.Interval = milliseconds; // Set to milliseconds
            myTimer.Enabled = true; // Turn it on
            myTimer.Start(); // Start it

            // When tick interval ends, stop timer
            myTimer.Tick += (s, e) =>
            {
                myTimer.Enabled = false;
                myTimer.Stop();
            };

            // Let the system do other things while the timer is going
            while (myTimer.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
