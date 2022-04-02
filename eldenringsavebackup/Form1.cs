using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eldenringsavebackup
{
    public partial class ERSaveLoader : Form
    {
        string userPath;
        string backupPath;

        public ERSaveLoader()
        {
            InitializeComponent();
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
            lblSaveLocation.Text = userPath;
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
            lblBackupLocation.Text = backupPath;

            // Change label to let user know information has been saved
            lblLocation.Text = "Save and backup location stored and ready for use";

        }

        private void ERSaveLoader_Load(object sender, EventArgs e)
        {
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
            lblBackupLocation.Text = backupPath;
            lblSaveLocation.Text = userPath;

            // If user has stored paths, set all buttons to enabled to give user full functionality
            btnBackup.Enabled = true;
            btnLoad.Enabled = true;
            btnBackupLocation.Enabled=true;
            btnSaveLocation.Enabled=true;

            // Set lbl to tell user saved are locations are ready for use
            lblLocation.Text = "Save and backup location stored and ready for use";
        }
    }
}
