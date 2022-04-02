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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERSaveLoader));
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBackupLocation = new System.Windows.Forms.Button();
            this.fbdSave = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBackupLocation = new System.Windows.Forms.Label();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnBackup.Enabled = false;
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackup.Location = new System.Drawing.Point(247, 122);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(150, 50);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup Current Save";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(247, 52);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 50);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Backup Save";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBackupLocation
            // 
            this.btnBackupLocation.Enabled = false;
            this.btnBackupLocation.Location = new System.Drawing.Point(62, 122);
            this.btnBackupLocation.Name = "btnBackupLocation";
            this.btnBackupLocation.Size = new System.Drawing.Size(150, 50);
            this.btnBackupLocation.TabIndex = 2;
            this.btnBackupLocation.Text = "Choose Backup File Location";
            this.btnBackupLocation.UseVisualStyleBackColor = true;
            this.btnBackupLocation.Click += new System.EventHandler(this.btnBackupLocation_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(62, 52);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(150, 50);
            this.btnSaveLocation.TabIndex = 3;
            this.btnSaveLocation.Text = "Choose Save File Location";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocation.Location = new System.Drawing.Point(103, 18);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 13);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBackupLocation
            // 
            this.lblBackupLocation.AutoSize = true;
            this.lblBackupLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBackupLocation.Location = new System.Drawing.Point(59, 175);
            this.lblBackupLocation.Name = "lblBackupLocation";
            this.lblBackupLocation.Size = new System.Drawing.Size(0, 13);
            this.lblBackupLocation.TabIndex = 5;
            this.lblBackupLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaveLocation.Location = new System.Drawing.Point(59, 105);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(0, 13);
            this.lblSaveLocation.TabIndex = 6;
            this.lblSaveLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ERSaveLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(455, 210);
            this.Controls.Add(this.lblSaveLocation);
            this.Controls.Add(this.lblBackupLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.btnBackupLocation);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBackup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ERSaveLoader";
            this.Text = "ER Save Load/Backup";
            this.Load += new System.EventHandler(this.ERSaveLoader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.FolderBrowserDialog fbdBackup;
        private System.Windows.Forms.Button btnBackupLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdSave;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBackupLocation;
        private System.Windows.Forms.Label lblSaveLocation;
    }
}

