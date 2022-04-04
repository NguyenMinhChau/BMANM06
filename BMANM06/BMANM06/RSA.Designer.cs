
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.labelNotifiupdate = new System.Windows.Forms.Label();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDecryptString = new System.Windows.Forms.Button();
            this.btnEncryptString = new System.Windows.Forms.Button();
            this.txtPlainTextStringDecrypt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCiphertextString = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlainTextString = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 510);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnGenerateKeyAuto);
            this.panel1.Controls.Add(this.cbKeyLength);
            this.panel1.Controls.Add(this.txtFileKey);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 175);
            this.panel1.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(460, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(196, 44);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Location = new System.Drawing.Point(494, 123);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(112, 34);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click_1);
            // 
            // btnGenerateKeyAuto
            // 
            this.btnGenerateKeyAuto.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.cbKeyLength.Size = new System.Drawing.Size(212, 33);
            this.cbKeyLength.TabIndex = 4;
            // 
            // txtFileKey
            // 
            this.txtFileKey.Location = new System.Drawing.Point(184, 123);
            this.txtFileKey.Name = "txtFileKey";
            this.txtFileKey.Size = new System.Drawing.Size(304, 33);
            this.txtFileKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "File Key (Xml)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Độ dài Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(262, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
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
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(3, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 261);
            this.panel2.TabIndex = 8;
            // 
            // txtMuGiaiMa
            // 
            this.txtMuGiaiMa.Location = new System.Drawing.Point(197, 190);
            this.txtMuGiaiMa.Name = "txtMuGiaiMa";
            this.txtMuGiaiMa.Size = new System.Drawing.Size(409, 33);
            this.txtMuGiaiMa.TabIndex = 7;
            // 
            // txtMuMaHoa
            // 
            this.txtMuMaHoa.Location = new System.Drawing.Point(197, 131);
            this.txtMuMaHoa.Name = "txtMuMaHoa";
            this.txtMuMaHoa.Size = new System.Drawing.Size(409, 33);
            this.txtMuMaHoa.TabIndex = 6;
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(197, 67);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(409, 33);
            this.txtModule.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mũ giải mã (D)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mũ mã hóa (E)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Module (N)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(240, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 27);
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
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(3, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 321);
            this.panel3.TabIndex = 9;
            // 
            // labelNotifiupdate
            // 
            this.labelNotifiupdate.AutoSize = true;
            this.labelNotifiupdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNotifiupdate.Location = new System.Drawing.Point(12, 280);
            this.labelNotifiupdate.Name = "labelNotifiupdate";
            this.labelNotifiupdate.Size = new System.Drawing.Size(87, 20);
            this.labelNotifiupdate.TabIndex = 14;
            this.labelNotifiupdate.Text = "Thông báo";
            // 
            // labelNotifi
            // 
            this.labelNotifi.AutoSize = true;
            this.labelNotifi.Location = new System.Drawing.Point(35, 280);
            this.labelNotifi.Name = "labelNotifi";
            this.labelNotifi.Size = new System.Drawing.Size(0, 25);
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
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.Location = new System.Drawing.Point(311, 203);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(112, 34);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.Location = new System.Drawing.Point(138, 203);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(112, 34);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFolder.Location = new System.Drawing.Point(475, 173);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(133, 34);
            this.btnOpenFolder.TabIndex = 9;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click_1);
            // 
            // btnSelectFolderOut
            // 
            this.btnSelectFolderOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolderOut.Location = new System.Drawing.Point(475, 133);
            this.btnSelectFolderOut.Name = "btnSelectFolderOut";
            this.btnSelectFolderOut.Size = new System.Drawing.Size(133, 34);
            this.btnSelectFolderOut.TabIndex = 8;
            this.btnSelectFolderOut.Text = "Select Folder";
            this.btnSelectFolderOut.UseVisualStyleBackColor = true;
            this.btnSelectFolderOut.Click += new System.EventHandler(this.btnSelectFolderOut_Click_1);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolder.Location = new System.Drawing.Point(475, 68);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(133, 34);
            this.btnSelectFolder.TabIndex = 7;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click_1);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFile.Location = new System.Drawing.Point(475, 28);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(133, 34);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(123, 155);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(346, 33);
            this.txtOutput.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(123, 55);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(346, 33);
            this.txtInput.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Output";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(127, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã hóa và giải mã File/Folder";
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
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(3, 778);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 321);
            this.panel4.TabIndex = 10;
            // 
            // txtSHA256
            // 
            this.txtSHA256.Location = new System.Drawing.Point(138, 248);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.Size = new System.Drawing.Size(468, 33);
            this.txtSHA256.TabIndex = 14;
            // 
            // txtSHA1
            // 
            this.txtSHA1.Location = new System.Drawing.Point(138, 202);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(468, 33);
            this.txtSHA1.TabIndex = 13;
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(138, 157);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(468, 33);
            this.txtMD5.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 25);
            this.label15.TabIndex = 11;
            this.label15.Text = "SHA256";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "SHA1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "MD5";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(30, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Check File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(475, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtFileKiemtra
            // 
            this.txtFileKiemtra.Location = new System.Drawing.Point(86, 57);
            this.txtFileKiemtra.Name = "txtFileKiemtra";
            this.txtFileKiemtra.Size = new System.Drawing.Size(383, 33);
            this.txtFileKiemtra.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "File";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(242, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kiểm tra file";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnDecryptString);
            this.panel5.Controls.Add(this.btnEncryptString);
            this.panel5.Controls.Add(this.txtPlainTextStringDecrypt);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.txtCiphertextString);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.txtPlainTextString);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(3, 1105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(663, 498);
            this.panel5.TabIndex = 12;
            // 
            // btnDecryptString
            // 
            this.btnDecryptString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryptString.Location = new System.Drawing.Point(496, 341);
            this.btnDecryptString.Name = "btnDecryptString";
            this.btnDecryptString.Size = new System.Drawing.Size(112, 34);
            this.btnDecryptString.TabIndex = 10;
            this.btnDecryptString.Text = "Decrypt";
            this.btnDecryptString.UseVisualStyleBackColor = true;
            this.btnDecryptString.Click += new System.EventHandler(this.btnDecryptString_Click);
            // 
            // btnEncryptString
            // 
            this.btnEncryptString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryptString.Location = new System.Drawing.Point(496, 199);
            this.btnEncryptString.Name = "btnEncryptString";
            this.btnEncryptString.Size = new System.Drawing.Size(112, 34);
            this.btnEncryptString.TabIndex = 9;
            this.btnEncryptString.Text = "Encrypt";
            this.btnEncryptString.UseVisualStyleBackColor = true;
            this.btnEncryptString.Click += new System.EventHandler(this.btnEncryptString_Click_1);
            // 
            // txtPlainTextStringDecrypt
            // 
            this.txtPlainTextStringDecrypt.Location = new System.Drawing.Point(37, 381);
            this.txtPlainTextStringDecrypt.Multiline = true;
            this.txtPlainTextStringDecrypt.Name = "txtPlainTextStringDecrypt";
            this.txtPlainTextStringDecrypt.Size = new System.Drawing.Size(571, 96);
            this.txtPlainTextStringDecrypt.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 348);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 25);
            this.label19.TabIndex = 7;
            this.label19.Text = "PlainText";
            // 
            // txtCiphertextString
            // 
            this.txtCiphertextString.Location = new System.Drawing.Point(37, 240);
            this.txtCiphertextString.Multiline = true;
            this.txtCiphertextString.Name = "txtCiphertextString";
            this.txtCiphertextString.Size = new System.Drawing.Size(571, 95);
            this.txtCiphertextString.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 25);
            this.label18.TabIndex = 5;
            this.label18.Text = "Ciphertext";
            // 
            // txtPlainTextString
            // 
            this.txtPlainTextString.Location = new System.Drawing.Point(37, 87);
            this.txtPlainTextString.Multiline = true;
            this.txtPlainTextString.Name = "txtPlainTextString";
            this.txtPlainTextString.Size = new System.Drawing.Size(569, 106);
            this.txtPlainTextString.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "PlainText";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(225, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(279, 27);
            this.label16.TabIndex = 2;
            this.label16.Text = "Mã hóa và giải mã chuỗi";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 510);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA | BMANM06_COMP104901";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RSA_FormClosing_1);
            this.Load += new System.EventHandler(this.RSA_Load_1);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnGenerateKeyAuto;
        private System.Windows.Forms.ComboBox cbKeyLength;
        private System.Windows.Forms.TextBox txtFileKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMuGiaiMa;
        private System.Windows.Forms.TextBox txtMuMaHoa;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNotifiupdate;
        private System.Windows.Forms.Label labelNotifi;
        private System.Windows.Forms.ProgressBar progressBarEnDe;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnSelectFolderOut;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFileKiemtra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDecryptString;
        private System.Windows.Forms.Button btnEncryptString;
        private System.Windows.Forms.TextBox txtPlainTextStringDecrypt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCiphertextString;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlainTextString;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnReset;
    }
}