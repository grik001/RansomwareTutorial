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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.btnGenerateServerKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
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
            this.txtTargetFilesDirectory.Location = new System.Drawing.Point(199, 55);
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
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Encrypt Location";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(461, 140);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(542, 140);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // pgProgress
            // 
            this.pgProgress.Location = new System.Drawing.Point(18, 83);
            this.pgProgress.Name = "pgProgress";
            this.pgProgress.Size = new System.Drawing.Size(599, 23);
            this.pgProgress.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(5, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(166, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Starting AES encryption";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton3.Location = new System.Drawing.Point(5, 47);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(161, 20);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Create local RSA keys";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton4.Location = new System.Drawing.Point(5, 99);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(121, 20);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Encrypting Data";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton5.Location = new System.Drawing.Point(6, 125);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(196, 20);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Encrypting Local Private Key";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton6.Location = new System.Drawing.Point(5, 151);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(181, 20);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Encrypting Local AES Key";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton7.Location = new System.Drawing.Point(6, 21);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(48, 20);
            this.radioButton7.TabIndex = 17;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Idle";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 182);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Location = new System.Drawing.Point(12, 357);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(605, 255);
            this.textBox4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Working Directory";
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Location = new System.Drawing.Point(218, 112);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(399, 22);
            this.txtWorkingDirectory.TabIndex = 19;
            this.txtWorkingDirectory.Text = "C:\\Users\\Keith\\Desktop\\WorkingDir";
            // 
            // btnGenerateServerKey
            // 
            this.btnGenerateServerKey.Location = new System.Drawing.Point(9, 621);
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
            this.label6.Location = new System.Drawing.Point(282, 621);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Delay";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(355, 618);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(262, 22);
            this.txtDelay.TabIndex = 22;
            // 
            // RansomTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(626, 656);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.btnGenerateServerKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWorkingDirectory);
            this.Controls.Add(this.textBox4);
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Button btnGenerateServerKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelay;
    }
}

