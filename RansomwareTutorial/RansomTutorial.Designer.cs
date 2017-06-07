namespace RansomwareTutorial
{
    partial class RansomTutorial
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetFilesDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.pgProgress = new System.Windows.Forms.ProgressBar();
            this.rdLocalRsaKeys = new System.Windows.Forms.RadioButton();
            this.rdEncryptData = new System.Windows.Forms.RadioButton();
            this.rdEncryptPrivateKey = new System.Windows.Forms.RadioButton();
            this.rdEncryptAES = new System.Windows.Forms.RadioButton();
            this.rdIdle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGetKeyFromServer = new System.Windows.Forms.RadioButton();
            this.rdDecryptFiles = new System.Windows.Forms.RadioButton();
            this.rdDecryptLocalKey = new System.Windows.Forms.RadioButton();
            this.rdDecryptAESKeys = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.btnGenerateServerKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.cbPause = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ransomware Tutorial";
            // 
            // txtTargetFilesDirectory
            // 
            this.txtTargetFilesDirectory.Location = new System.Drawing.Point(199, 43);
            this.txtTargetFilesDirectory.Name = "txtTargetFilesDirectory";
            this.txtTargetFilesDirectory.Size = new System.Drawing.Size(418, 22);
            this.txtTargetFilesDirectory.TabIndex = 2;
            this.txtTargetFilesDirectory.Text = "C:\\Users\\Keith\\Desktop\\RansomTutorial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Encrypt Location";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(409, 140);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(490, 140);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(127, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Pay Ransom";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // pgProgress
            // 
            this.pgProgress.Location = new System.Drawing.Point(18, 71);
            this.pgProgress.Name = "pgProgress";
            this.pgProgress.Size = new System.Drawing.Size(599, 23);
            this.pgProgress.TabIndex = 6;
            // 
            // rdLocalRsaKeys
            // 
            this.rdLocalRsaKeys.AutoSize = true;
            this.rdLocalRsaKeys.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdLocalRsaKeys.Location = new System.Drawing.Point(5, 47);
            this.rdLocalRsaKeys.Name = "rdLocalRsaKeys";
            this.rdLocalRsaKeys.Size = new System.Drawing.Size(161, 20);
            this.rdLocalRsaKeys.TabIndex = 13;
            this.rdLocalRsaKeys.Text = "Create local RSA keys";
            this.rdLocalRsaKeys.UseVisualStyleBackColor = true;
            // 
            // rdEncryptData
            // 
            this.rdEncryptData.AutoSize = true;
            this.rdEncryptData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdEncryptData.Location = new System.Drawing.Point(6, 73);
            this.rdEncryptData.Name = "rdEncryptData";
            this.rdEncryptData.Size = new System.Drawing.Size(121, 20);
            this.rdEncryptData.TabIndex = 14;
            this.rdEncryptData.Text = "Encrypting Data";
            this.rdEncryptData.UseVisualStyleBackColor = true;
            // 
            // rdEncryptPrivateKey
            // 
            this.rdEncryptPrivateKey.AutoSize = true;
            this.rdEncryptPrivateKey.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdEncryptPrivateKey.Location = new System.Drawing.Point(5, 125);
            this.rdEncryptPrivateKey.Name = "rdEncryptPrivateKey";
            this.rdEncryptPrivateKey.Size = new System.Drawing.Size(196, 20);
            this.rdEncryptPrivateKey.TabIndex = 15;
            this.rdEncryptPrivateKey.Text = "Encrypting Local Private Key";
            this.rdEncryptPrivateKey.UseVisualStyleBackColor = true;
            // 
            // rdEncryptAES
            // 
            this.rdEncryptAES.AutoSize = true;
            this.rdEncryptAES.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdEncryptAES.Location = new System.Drawing.Point(6, 99);
            this.rdEncryptAES.Name = "rdEncryptAES";
            this.rdEncryptAES.Size = new System.Drawing.Size(152, 20);
            this.rdEncryptAES.TabIndex = 16;
            this.rdEncryptAES.Text = "Encrypting AES Keys";
            this.rdEncryptAES.UseVisualStyleBackColor = true;
            // 
            // rdIdle
            // 
            this.rdIdle.AutoSize = true;
            this.rdIdle.Checked = true;
            this.rdIdle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdIdle.Location = new System.Drawing.Point(6, 21);
            this.rdIdle.Name = "rdIdle";
            this.rdIdle.Size = new System.Drawing.Size(48, 20);
            this.rdIdle.TabIndex = 17;
            this.rdIdle.TabStop = true;
            this.rdIdle.Text = "Idle";
            this.rdIdle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.rdGetKeyFromServer);
            this.groupBox1.Controls.Add(this.rdDecryptFiles);
            this.groupBox1.Controls.Add(this.rdDecryptLocalKey);
            this.groupBox1.Controls.Add(this.rdDecryptAESKeys);
            this.groupBox1.Controls.Add(this.rdIdle);
            this.groupBox1.Controls.Add(this.rdEncryptAES);
            this.groupBox1.Controls.Add(this.rdLocalRsaKeys);
            this.groupBox1.Controls.Add(this.rdEncryptPrivateKey);
            this.groupBox1.Controls.Add(this.rdEncryptData);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 446);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rdGetKeyFromServer
            // 
            this.rdGetKeyFromServer.AutoSize = true;
            this.rdGetKeyFromServer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdGetKeyFromServer.Location = new System.Drawing.Point(6, 151);
            this.rdGetKeyFromServer.Name = "rdGetKeyFromServer";
            this.rdGetKeyFromServer.Size = new System.Drawing.Size(189, 20);
            this.rdGetKeyFromServer.TabIndex = 22;
            this.rdGetKeyFromServer.Text = "Get Private key from Server";
            this.rdGetKeyFromServer.UseVisualStyleBackColor = true;
            // 
            // rdDecryptFiles
            // 
            this.rdDecryptFiles.AutoSize = true;
            this.rdDecryptFiles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdDecryptFiles.Location = new System.Drawing.Point(5, 229);
            this.rdDecryptFiles.Name = "rdDecryptFiles";
            this.rdDecryptFiles.Size = new System.Drawing.Size(105, 20);
            this.rdDecryptFiles.TabIndex = 21;
            this.rdDecryptFiles.Text = "Decrypt Files";
            this.rdDecryptFiles.UseVisualStyleBackColor = true;
            // 
            // rdDecryptLocalKey
            // 
            this.rdDecryptLocalKey.AutoSize = true;
            this.rdDecryptLocalKey.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdDecryptLocalKey.Location = new System.Drawing.Point(5, 177);
            this.rdDecryptLocalKey.Name = "rdDecryptLocalKey";
            this.rdDecryptLocalKey.Size = new System.Drawing.Size(135, 20);
            this.rdDecryptLocalKey.TabIndex = 18;
            this.rdDecryptLocalKey.Text = "Decrypt Local Key";
            this.rdDecryptLocalKey.UseVisualStyleBackColor = true;
            // 
            // rdDecryptAESKeys
            // 
            this.rdDecryptAESKeys.AutoSize = true;
            this.rdDecryptAESKeys.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdDecryptAESKeys.Location = new System.Drawing.Point(6, 203);
            this.rdDecryptAESKeys.Name = "rdDecryptAESKeys";
            this.rdDecryptAESKeys.Size = new System.Drawing.Size(175, 20);
            this.rdDecryptAESKeys.TabIndex = 19;
            this.rdDecryptAESKeys.Text = "Decrypt Local  AES Keys";
            this.rdDecryptAESKeys.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Working Directory";
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Location = new System.Drawing.Point(218, 100);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(399, 22);
            this.txtWorkingDirectory.TabIndex = 19;
            this.txtWorkingDirectory.Text = "C:\\Users\\Keith\\Desktop\\WorkingDir";
            // 
            // btnGenerateServerKey
            // 
            this.btnGenerateServerKey.Location = new System.Drawing.Point(12, 621);
            this.btnGenerateServerKey.Name = "btnGenerateServerKey";
            this.btnGenerateServerKey.Size = new System.Drawing.Size(189, 23);
            this.btnGenerateServerKey.TabIndex = 21;
            this.btnGenerateServerKey.Text = "Generate Server Private Key";
            this.btnGenerateServerKey.UseVisualStyleBackColor = true;
            this.btnGenerateServerKey.Click += new System.EventHandler(this.btnGenerateServerKey_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(286, 625);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Delay";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(355, 622);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(262, 22);
            this.txtDelay.TabIndex = 22;
            this.txtDelay.Text = "2000";
            // 
            // cbPause
            // 
            this.cbPause.AutoSize = true;
            this.cbPause.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbPause.Location = new System.Drawing.Point(450, 596);
            this.cbPause.Name = "cbPause";
            this.cbPause.Size = new System.Drawing.Size(167, 20);
            this.cbPause.TabIndex = 25;
            this.cbPause.Text = "Pause Between Stages";
            this.cbPause.UseVisualStyleBackColor = true;
            // 
            // RansomTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(626, 656);
            this.Controls.Add(this.cbPause);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.btnGenerateServerKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWorkingDirectory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pgProgress);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTargetFilesDirectory);
            this.Controls.Add(this.label2);
            this.Name = "RansomTutorial";
            this.Text = "RansomTutorial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetFilesDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ProgressBar pgProgress;
        private System.Windows.Forms.RadioButton rdLocalRsaKeys;
        private System.Windows.Forms.RadioButton rdEncryptData;
        private System.Windows.Forms.RadioButton rdEncryptPrivateKey;
        private System.Windows.Forms.RadioButton rdEncryptAES;
        private System.Windows.Forms.RadioButton rdIdle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Button btnGenerateServerKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.RadioButton rdGetKeyFromServer;
        private System.Windows.Forms.RadioButton rdDecryptFiles;
        private System.Windows.Forms.RadioButton rdDecryptLocalKey;
        private System.Windows.Forms.RadioButton rdDecryptAESKeys;
        private System.Windows.Forms.CheckBox cbPause;
    }
}

