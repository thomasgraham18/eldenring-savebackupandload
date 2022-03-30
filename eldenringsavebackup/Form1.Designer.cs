namespace eldenringsavebackup
{
    partial class ERSaveLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBackupLocation = new System.Windows.Forms.Button();
            this.fbdSave = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnBackup.Enabled = false;
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackup.Location = new System.Drawing.Point(240, 32);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(150, 50);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(240, 102);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 50);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBackupLocation
            // 
            this.btnBackupLocation.Enabled = false;
            this.btnBackupLocation.Location = new System.Drawing.Point(62, 102);
            this.btnBackupLocation.Name = "btnBackupLocation";
            this.btnBackupLocation.Size = new System.Drawing.Size(150, 50);
            this.btnBackupLocation.TabIndex = 2;
            this.btnBackupLocation.Text = "Open Backup File Location";
            this.btnBackupLocation.UseVisualStyleBackColor = true;
            this.btnBackupLocation.Click += new System.EventHandler(this.btnBackupLocation_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(62, 32);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(150, 50);
            this.btnSaveLocation.TabIndex = 3;
            this.btnSaveLocation.Text = "Open Save File Location";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // ERSaveLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(449, 184);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.btnBackupLocation);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBackup);
            this.Name = "ERSaveLoader";
            this.Text = "ER Save Load/Backup";
            this.Load += new System.EventHandler(this.ERSaveLoader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.FolderBrowserDialog fbdBackup;
        private System.Windows.Forms.Button btnBackupLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdSave;
        private System.Windows.Forms.Button btnSaveLocation;
    }
}

