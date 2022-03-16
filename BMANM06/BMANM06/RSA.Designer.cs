
namespace BMANM06
{
    partial class RSA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnGenerateKeyAuto = new System.Windows.Forms.Button();
            this.cbKeyLength = new System.Windows.Forms.ComboBox();
            this.txtFileKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMuGiaiMa = new System.Windows.Forms.TextBox();
            this.txtMuMaHoa = new System.Windows.Forms.TextBox();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNotifi = new System.Windows.Forms.Label();
            this.progressBarEnDe = new System.Windows.Forms.ProgressBar();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnSelectFolderOut = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFileKiemtra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelNotifiupdate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnGenerateKeyAuto);
            this.panel1.Controls.Add(this.cbKeyLength);
            this.panel1.Controls.Add(this.txtFileKey);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(29, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 261);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(494, 123);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(112, 34);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnGenerateKeyAuto
            // 
            this.btnGenerateKeyAuto.Location = new System.Drawing.Point(376, 57);
            this.btnGenerateKeyAuto.Name = "btnGenerateKeyAuto";
            this.btnGenerateKeyAuto.Size = new System.Drawing.Size(230, 34);
            this.btnGenerateKeyAuto.TabIndex = 5;
            this.btnGenerateKeyAuto.Text = "Tạo Key tự động";
            this.btnGenerateKeyAuto.UseVisualStyleBackColor = true;
            this.btnGenerateKeyAuto.Click += new System.EventHandler(this.btnGenerateKeyAuto_Click);
            // 
            // cbKeyLength
            // 
            this.cbKeyLength.FormattingEnabled = true;
            this.cbKeyLength.Location = new System.Drawing.Point(156, 57);
            this.cbKeyLength.Name = "cbKeyLength";
            this.cbKeyLength.Size = new System.Drawing.Size(212, 28);
            this.cbKeyLength.TabIndex = 4;
            // 
            // txtFileKey
            // 
            this.txtFileKey.Location = new System.Drawing.Point(156, 123);
            this.txtFileKey.Name = "txtFileKey";
            this.txtFileKey.Size = new System.Drawing.Size(332, 28);
            this.txtFileKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "File Key (Xml)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Độ dài Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo Key";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtMuGiaiMa);
            this.panel2.Controls.Add(this.txtMuMaHoa);
            this.panel2.Controls.Add(this.txtModule);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(668, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 261);
            this.panel2.TabIndex = 1;
            // 
            // txtMuGiaiMa
            // 
            this.txtMuGiaiMa.Location = new System.Drawing.Point(163, 190);
            this.txtMuGiaiMa.Name = "txtMuGiaiMa";
            this.txtMuGiaiMa.Size = new System.Drawing.Size(398, 28);
            this.txtMuGiaiMa.TabIndex = 7;
            // 
            // txtMuMaHoa
            // 
            this.txtMuMaHoa.Location = new System.Drawing.Point(162, 131);
            this.txtMuMaHoa.Name = "txtMuMaHoa";
            this.txtMuMaHoa.Size = new System.Drawing.Size(398, 28);
            this.txtMuMaHoa.TabIndex = 6;
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(162, 67);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(398, 28);
            this.txtModule.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mũ giải mã (D)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mũ mã hóa (E)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Module (N)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(240, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin Key";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelNotifiupdate);
            this.panel3.Controls.Add(this.labelNotifi);
            this.panel3.Controls.Add(this.progressBarEnDe);
            this.panel3.Controls.Add(this.btnDecrypt);
            this.panel3.Controls.Add(this.btnEncrypt);
            this.panel3.Controls.Add(this.btnOpenFolder);
            this.panel3.Controls.Add(this.btnSelectFolderOut);
            this.panel3.Controls.Add(this.btnSelectFolder);
            this.panel3.Controls.Add(this.btnSelectFile);
            this.panel3.Controls.Add(this.txtOutput);
            this.panel3.Controls.Add(this.txtInput);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(29, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 321);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelNotifi
            // 
            this.labelNotifi.AutoSize = true;
            this.labelNotifi.Location = new System.Drawing.Point(35, 280);
            this.labelNotifi.Name = "labelNotifi";
            this.labelNotifi.Size = new System.Drawing.Size(0, 20);
            this.labelNotifi.TabIndex = 13;
            this.labelNotifi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarEnDe
            // 
            this.progressBarEnDe.Location = new System.Drawing.Point(35, 243);
            this.progressBarEnDe.Name = "progressBarEnDe";
            this.progressBarEnDe.Size = new System.Drawing.Size(573, 34);
            this.progressBarEnDe.TabIndex = 12;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(311, 203);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(112, 34);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(138, 203);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(112, 34);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(475, 173);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(133, 34);
            this.btnOpenFolder.TabIndex = 9;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnSelectFolderOut
            // 
            this.btnSelectFolderOut.Location = new System.Drawing.Point(475, 133);
            this.btnSelectFolderOut.Name = "btnSelectFolderOut";
            this.btnSelectFolderOut.Size = new System.Drawing.Size(133, 34);
            this.btnSelectFolderOut.TabIndex = 8;
            this.btnSelectFolderOut.Text = "Select Folder";
            this.btnSelectFolderOut.UseVisualStyleBackColor = true;
            this.btnSelectFolderOut.Click += new System.EventHandler(this.btnSelectFolderOut_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(475, 68);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(133, 34);
            this.btnSelectFolder.TabIndex = 7;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(475, 28);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(133, 34);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(123, 155);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(346, 28);
            this.txtOutput.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(123, 55);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(346, 28);
            this.txtInput.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Output";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(231, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã hóa và giải mã";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtSHA256);
            this.panel4.Controls.Add(this.txtSHA1);
            this.panel4.Controls.Add(this.txtMD5);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txtFileKiemtra);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(698, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 321);
            this.panel4.TabIndex = 3;
            // 
            // txtSHA256
            // 
            this.txtSHA256.Location = new System.Drawing.Point(113, 248);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.Size = new System.Drawing.Size(437, 28);
            this.txtSHA256.TabIndex = 14;
            // 
            // txtSHA1
            // 
            this.txtSHA1.Location = new System.Drawing.Point(113, 202);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(437, 28);
            this.txtSHA1.TabIndex = 13;
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(113, 157);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(437, 28);
            this.txtMD5.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "SHA256";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "SHA1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "MD5";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Kiểm tra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileKiemtra
            // 
            this.txtFileKiemtra.Location = new System.Drawing.Point(86, 57);
            this.txtFileKiemtra.Name = "txtFileKiemtra";
            this.txtFileKiemtra.Size = new System.Drawing.Size(312, 28);
            this.txtFileKiemtra.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "File";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(242, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kiểm tra file";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(575, 656);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(196, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelNotifiupdate
            // 
            this.labelNotifiupdate.AutoSize = true;
            this.labelNotifiupdate.Location = new System.Drawing.Point(12, 280);
            this.labelNotifiupdate.Name = "labelNotifiupdate";
            this.labelNotifiupdate.Size = new System.Drawing.Size(87, 20);
            this.labelNotifiupdate.TabIndex = 14;
            this.labelNotifiupdate.Text = "Thông báo";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 702);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RSA_FormClosing);
            this.Load += new System.EventHandler(this.RSA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnGenerateKeyAuto;
        private System.Windows.Forms.ComboBox cbKeyLength;
        private System.Windows.Forms.TextBox txtFileKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMuGiaiMa;
        private System.Windows.Forms.TextBox txtMuMaHoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnSelectFolderOut;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.ProgressBar progressBarEnDe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFileKiemtra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelNotifi;
        private System.Windows.Forms.Label labelNotifiupdate;
    }
}