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
            this.btnCopy = new System.Windows.Forms.Button();
            this.cboFromSaveSlot = new System.Windows.Forms.ComboBox();
            this.cboToSaveSlot = new System.Windows.Forms.ComboBox();
            this.txtDestFile = new System.Windows.Forms.TextBox();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.btnDestFile = new System.Windows.Forms.Button();
            this.lblDestFile = new System.Windows.Forms.Label();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.lblCopyTo = new System.Windows.Forms.Label();
            this.lblCopyFrom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBackupStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnBackup.Enabled = false;
            this.btnBackup.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackup.Location = new System.Drawing.Point(59, 246);
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
            this.btnLoad.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(257, 246);
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
            this.btnBackupLocation.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupLocation.Location = new System.Drawing.Point(327, 149);
            this.btnBackupLocation.Name = "btnBackupLocation";
            this.btnBackupLocation.Size = new System.Drawing.Size(80, 30);
            this.btnBackupLocation.TabIndex = 2;
            this.btnBackupLocation.Text = "Browse";
            this.btnBackupLocation.UseVisualStyleBackColor = true;
            this.btnBackupLocation.Click += new System.EventHandler(this.btnBackupLocation_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocation.Location = new System.Drawing.Point(327, 101);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(80, 30);
            this.btnSaveLocation.TabIndex = 3;
            this.btnSaveLocation.Text = "Browse";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocation.Location = new System.Drawing.Point(37, 69);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 21);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBackupLocation
            // 
            this.lblBackupLocation.AutoSize = true;
            this.lblBackupLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblBackupLocation.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBackupLocation.Location = new System.Drawing.Point(21, 158);
            this.lblBackupLocation.Name = "lblBackupLocation";
            this.lblBackupLocation.Size = new System.Drawing.Size(69, 21);
            this.lblBackupLocation.TabIndex = 5;
            this.lblBackupLocation.Text = "Backup:";
            this.lblBackupLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveLocation.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaveLocation.Location = new System.Drawing.Point(37, 110);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(49, 21);
            this.lblSaveLocation.TabIndex = 6;
            this.lblSaveLocation.Text = "Save:";
            this.lblSaveLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(184, 337);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(99, 40);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cboFromSaveSlot
            // 
            this.cboFromSaveSlot.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFromSaveSlot.FormattingEnabled = true;
            this.cboFromSaveSlot.Location = new System.Drawing.Point(70, 257);
            this.cboFromSaveSlot.Name = "cboFromSaveSlot";
            this.cboFromSaveSlot.Size = new System.Drawing.Size(121, 29);
            this.cboFromSaveSlot.TabIndex = 8;
            this.cboFromSaveSlot.SelectedIndexChanged += new System.EventHandler(this.cboFromSaveSlot_SelectedIndexChanged);
            // 
            // cboToSaveSlot
            // 
            this.cboToSaveSlot.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboToSaveSlot.FormattingEnabled = true;
            this.cboToSaveSlot.Location = new System.Drawing.Point(264, 257);
            this.cboToSaveSlot.Name = "cboToSaveSlot";
            this.cboToSaveSlot.Size = new System.Drawing.Size(121, 29);
            this.cboToSaveSlot.TabIndex = 9;
            this.cboToSaveSlot.SelectedIndexChanged += new System.EventHandler(this.cboToSaveSlot_SelectedIndexChanged);
            // 
            // txtDestFile
            // 
            this.txtDestFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestFile.Location = new System.Drawing.Point(127, 150);
            this.txtDestFile.Name = "txtDestFile";
            this.txtDestFile.Size = new System.Drawing.Size(225, 26);
            this.txtDestFile.TabIndex = 10;
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceFile.Location = new System.Drawing.Point(127, 100);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(225, 26);
            this.txtSourceFile.TabIndex = 11;
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSourceFile.Location = new System.Drawing.Point(358, 100);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(80, 30);
            this.btnSourceFile.TabIndex = 12;
            this.btnSourceFile.Text = "Browse";
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.btnSourceFile_Click);
            // 
            // btnDestFile
            // 
            this.btnDestFile.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestFile.Location = new System.Drawing.Point(358, 149);
            this.btnDestFile.Name = "btnDestFile";
            this.btnDestFile.Size = new System.Drawing.Size(80, 30);
            this.btnDestFile.TabIndex = 13;
            this.btnDestFile.Text = "Browse";
            this.btnDestFile.UseVisualStyleBackColor = true;
            this.btnDestFile.Click += new System.EventHandler(this.btnDestFile_Click);
            // 
            // lblDestFile
            // 
            this.lblDestFile.AutoSize = true;
            this.lblDestFile.BackColor = System.Drawing.Color.Transparent;
            this.lblDestFile.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDestFile.Location = new System.Drawing.Point(15, 158);
            this.lblDestFile.Name = "lblDestFile";
            this.lblDestFile.Size = new System.Drawing.Size(106, 21);
            this.lblDestFile.TabIndex = 15;
            this.lblDestFile.Text = "Destination:";
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.BackColor = System.Drawing.Color.Transparent;
            this.lblSourceFile.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSourceFile.Location = new System.Drawing.Point(52, 108);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(69, 21);
            this.lblSourceFile.TabIndex = 16;
            this.lblSourceFile.Text = "Source:";
            // 
            // lblCopyTo
            // 
            this.lblCopyTo.AutoSize = true;
            this.lblCopyTo.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyTo.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCopyTo.Location = new System.Drawing.Point(288, 224);
            this.lblCopyTo.Name = "lblCopyTo";
            this.lblCopyTo.Size = new System.Drawing.Size(74, 21);
            this.lblCopyTo.TabIndex = 17;
            this.lblCopyTo.Text = "Copy to:";
            // 
            // lblCopyFrom
            // 
            this.lblCopyFrom.AutoSize = true;
            this.lblCopyFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyFrom.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCopyFrom.Location = new System.Drawing.Point(81, 224);
            this.lblCopyFrom.Name = "lblCopyFrom";
            this.lblCopyFrom.Size = new System.Drawing.Size(93, 21);
            this.lblCopyFrom.TabIndex = 18;
            this.lblCopyFrom.Text = "Copy from:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSourceFile);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.lblCopyFrom);
            this.panel1.Controls.Add(this.lblCopyTo);
            this.panel1.Controls.Add(this.txtDestFile);
            this.panel1.Controls.Add(this.cboToSaveSlot);
            this.panel1.Controls.Add(this.txtSourceFile);
            this.panel1.Controls.Add(this.cboFromSaveSlot);
            this.panel1.Controls.Add(this.btnSourceFile);
            this.panel1.Controls.Add(this.lblDestFile);
            this.panel1.Controls.Add(this.btnDestFile);
            this.panel1.Location = new System.Drawing.Point(538, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 425);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mantinia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(127, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = "Profile Transfer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.lblBackupStatus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSaveLocation);
            this.panel2.Controls.Add(this.txtBackupLocation);
            this.panel2.Controls.Add(this.btnSaveLocation);
            this.panel2.Controls.Add(this.btnBackup);
            this.panel2.Controls.Add(this.lblSaveLocation);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.lblBackupLocation);
            this.panel2.Controls.Add(this.btnBackupLocation);
            this.panel2.Controls.Add(this.lblLocation);
            this.panel2.Location = new System.Drawing.Point(12, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 425);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mantinia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(135, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "Save Backup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaveLocation.Location = new System.Drawing.Point(96, 102);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(225, 26);
            this.txtSaveLocation.TabIndex = 19;
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupLocation.Location = new System.Drawing.Point(96, 149);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.Size = new System.Drawing.Size(225, 26);
            this.txtBackupLocation.TabIndex = 20;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1000, 25);
            this.pnlTitle.TabIndex = 21;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(977, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 19);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBackupStatus
            // 
            this.lblBackupStatus.AutoSize = true;
            this.lblBackupStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblBackupStatus.Font = new System.Drawing.Font("Mantinia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBackupStatus.Location = new System.Drawing.Point(156, 347);
            this.lblBackupStatus.Name = "lblBackupStatus";
            this.lblBackupStatus.Size = new System.Drawing.Size(0, 21);
            this.lblBackupStatus.TabIndex = 22;
            this.lblBackupStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mantinia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(440, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "ER SBL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ERSaveLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ERSaveLoader";
            this.Text = "ER Save Load/Backup";
            this.Load += new System.EventHandler(this.ERSaveLoader_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ERSaveLoader_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cboFromSaveSlot;
        private System.Windows.Forms.ComboBox cboToSaveSlot;
        private System.Windows.Forms.TextBox txtDestFile;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.Button btnDestFile;
        private System.Windows.Forms.Label lblDestFile;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.Label lblCopyTo;
        private System.Windows.Forms.Label lblCopyFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.TextBox txtBackupLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBackupStatus;
        private System.Windows.Forms.Label label3;
    }
}

