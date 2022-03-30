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
            string sourceFile1 = $"{userPath}\\ER0000.sl2";
            string sourceFile2 = $"{userPath}\\ER0000.sl2.bak";
            string sourceFile3 = $"{userPath}\\steam_autocloud.vdf";
            string destinationFile1 = $"{backupPath}\\ER0000.sl2";
            string destinationFile2 = $"{backupPath}\\ER0000.sl2.bak";
            string destinationFile3 = $"{backupPath}\\steam_autocloud.vdf";
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
            string sourceFile1 = $"{backupPath}\\ER0000.sl2";
            string sourceFile2 = $"{backupPath}\\ER0000.sl2.bak";
            string sourceFile3 = $"{backupPath}\\steam_autocloud.vdf";
            string destinationFile1 = $"{userPath}\\ER0000.sl2";
            string destinationFile2 = $"{userPath}\\ER0000.sl2.bak";
            string destinationFile3 = $"{userPath}\\steam_autocloud.vdf";
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

        private void btnBackupLocation_Click(object sender, EventArgs e)
        {
            fbdBackup.RootFolder = Environment.SpecialFolder.ApplicationData;
            fbdBackup.ShowDialog();
            backupPath = fbdBackup.SelectedPath;
            btnBackup.Enabled = true;
            btnLoad.Enabled = true;
            btnSaveLocation.Enabled = true;

        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            fbdSave.RootFolder = Environment.SpecialFolder.ApplicationData;
            fbdSave.ShowDialog();
            userPath = fbdSave.SelectedPath;
            btnBackupLocation.Enabled = true;
            btnSaveLocation.Enabled = false;
            btnBackup.Enabled = false;
            btnLoad.Enabled = false;
        }

    }
}
