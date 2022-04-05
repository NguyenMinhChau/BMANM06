namespace BMANM06
{
    partial class RSASignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSASignForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.F_rsa_soPhiN = new System.Windows.Forms.TextBox();
            this.F_rsa_soQ = new System.Windows.Forms.TextBox();
            this.F_rsa_soP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.F_rsa_soE = new System.Windows.Forms.TextBox();
            this.F_rsa_soN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.F_rsa_soD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.F_rsa_TaoKhoa = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btThucHienKy_RSA = new System.Windows.Forms.Button();
            this.btChonFileKy_RSA = new System.Windows.Forms.Button();
            this.txtDuongDanFileKy_RSA = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTepKyDuocGuiDi_RSA = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btKiemTraXacThuc_RSA = new System.Windows.Forms.Button();
            this.btChonFileXacThuc_RSA = new System.Windows.Forms.Button();
            this.txtDuongDanFileXacThuc_RSA = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btThoatEF_RSA = new System.Windows.Forms.Button();
            this.btTaoChuKymoi_RSA = new System.Windows.Forms.Button();
            this.btChonVBMoiRSA = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.F_rsa_TaoKhoa);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.groupBox7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(657, 501);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.F_rsa_soPhiN);
            this.groupBox1.Controls.Add(this.F_rsa_soQ);
            this.groupBox1.Controls.Add(this.F_rsa_soP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo khóa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(18, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(367, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Các giá trị d, p, q và φ(n) cần được giữ bí mật";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(18, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(391, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Với p ≠ q, lựa chọn ngẫu nhiên đủ lớn và độc lập";
            // 
            // F_rsa_soPhiN
            // 
            this.F_rsa_soPhiN.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.F_rsa_soPhiN.Location = new System.Drawing.Point(340, 89);
            this.F_rsa_soPhiN.Name = "F_rsa_soPhiN";
            this.F_rsa_soPhiN.Size = new System.Drawing.Size(268, 33);
            this.F_rsa_soPhiN.TabIndex = 5;
            // 
            // F_rsa_soQ
            // 
            this.F_rsa_soQ.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.F_rsa_soQ.Location = new System.Drawing.Point(479, 37);
            this.F_rsa_soQ.Name = "F_rsa_soQ";
            this.F_rsa_soQ.Size = new System.Drawing.Size(129, 33);
            this.F_rsa_soQ.TabIndex = 4;
            // 
            // F_rsa_soP
            // 
            this.F_rsa_soP.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.F_rsa_soP.Location = new System.Drawing.Point(177, 37);
            this.F_rsa_soP.Name = "F_rsa_soP";
            this.F_rsa_soP.Size = new System.Drawing.Size(134, 33);
            this.F_rsa_soP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hàm số Ơle φ(n) = (p-1)*(q-1) = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(317, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số nguyên tố q = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số nguyên tố p = ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.F_rsa_soE);
            this.groupBox2.Controls.Add(this.F_rsa_soN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cặp khóa công khai {e,N}";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(13, 130);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(595, 60);
            this.label12.TabIndex = 11;
            this.label12.Text = resources.GetString("label12.Text");
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // F_rsa_soE
            // 
            this.F_rsa_soE.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.F_rsa_soE.Location = new System.Drawing.Point(318, 85);
            this.F_rsa_soE.Name = "F_rsa_soE";
            this.F_rsa_soE.Size = new System.Drawing.Size(290, 33);
            this.F_rsa_soE.TabIndex = 4;
            // 
            // F_rsa_soN
            // 
            this.F_rsa_soN.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.F_rsa_soN.Location = new System.Drawing.Point(318, 41);
            this.F_rsa_soN.Name = "F_rsa_soN";
            this.F_rsa_soN.Size = new System.Drawing.Size(290, 33);
            this.F_rsa_soN.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số mũ công khai e =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số module công khai n = p*q = ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.F_rsa_soD);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(3, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 105);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khóa bí mật {d,N}";
            // 
            // F_rsa_soD
            // 
            this.F_rsa_soD.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.F_rsa_soD.Location = new System.Drawing.Point(220, 35);
            this.F_rsa_soD.Name = "F_rsa_soD";
            this.F_rsa_soD.Size = new System.Drawing.Size(388, 33);
            this.F_rsa_soD.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "d = 1/e (mode φ(n)) = ";
            // 
            // F_rsa_TaoKhoa
            // 
            this.F_rsa_TaoKhoa.BackColor = System.Drawing.Color.NavajoWhite;
            this.F_rsa_TaoKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.F_rsa_TaoKhoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.F_rsa_TaoKhoa.ForeColor = System.Drawing.Color.Red;
            this.F_rsa_TaoKhoa.Location = new System.Drawing.Point(3, 547);
            this.F_rsa_TaoKhoa.Name = "F_rsa_TaoKhoa";
            this.F_rsa_TaoKhoa.Size = new System.Drawing.Size(620, 34);
            this.F_rsa_TaoKhoa.TabIndex = 3;
            this.F_rsa_TaoKhoa.Text = "Tạo khóa tự động";
            this.F_rsa_TaoKhoa.UseVisualStyleBackColor = false;
            this.F_rsa_TaoKhoa.Click += new System.EventHandler(this.F_rsa_TaoKhoa_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btThucHienKy_RSA);
            this.groupBox4.Controls.Add(this.btChonFileKy_RSA);
            this.groupBox4.Controls.Add(this.txtDuongDanFileKy_RSA);
            this.groupBox4.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(3, 587);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(620, 132);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn file thực hiện ký";
            // 
            // btThucHienKy_RSA
            // 
            this.btThucHienKy_RSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btThucHienKy_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThucHienKy_RSA.ForeColor = System.Drawing.Color.White;
            this.btThucHienKy_RSA.Location = new System.Drawing.Point(353, 80);
            this.btThucHienKy_RSA.Name = "btThucHienKy_RSA";
            this.btThucHienKy_RSA.Size = new System.Drawing.Size(261, 34);
            this.btThucHienKy_RSA.TabIndex = 2;
            this.btThucHienKy_RSA.Text = "Thực hiện ký lên văn bản";
            this.btThucHienKy_RSA.UseVisualStyleBackColor = false;
            this.btThucHienKy_RSA.Click += new System.EventHandler(this.btThucHienKy_RSA_Click);
            // 
            // btChonFileKy_RSA
            // 
            this.btChonFileKy_RSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btChonFileKy_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChonFileKy_RSA.ForeColor = System.Drawing.Color.White;
            this.btChonFileKy_RSA.Location = new System.Drawing.Point(494, 40);
            this.btChonFileKy_RSA.Name = "btChonFileKy_RSA";
            this.btChonFileKy_RSA.Size = new System.Drawing.Size(120, 34);
            this.btChonFileKy_RSA.TabIndex = 1;
            this.btChonFileKy_RSA.Text = "Open file";
            this.btChonFileKy_RSA.UseVisualStyleBackColor = false;
            this.btChonFileKy_RSA.Click += new System.EventHandler(this.btChonFileKy_RSA_Click);
            // 
            // txtDuongDanFileKy_RSA
            // 
            this.txtDuongDanFileKy_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuongDanFileKy_RSA.Location = new System.Drawing.Point(9, 40);
            this.txtDuongDanFileKy_RSA.Name = "txtDuongDanFileKy_RSA";
            this.txtDuongDanFileKy_RSA.Size = new System.Drawing.Size(479, 33);
            this.txtDuongDanFileKy_RSA.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTepKyDuocGuiDi_RSA);
            this.groupBox5.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(3, 725);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(620, 267);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tệp chữ ký vào file được gửi đi";
            // 
            // txtTepKyDuocGuiDi_RSA
            // 
            this.txtTepKyDuocGuiDi_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTepKyDuocGuiDi_RSA.Location = new System.Drawing.Point(9, 40);
            this.txtTepKyDuocGuiDi_RSA.Multiline = true;
            this.txtTepKyDuocGuiDi_RSA.Name = "txtTepKyDuocGuiDi_RSA";
            this.txtTepKyDuocGuiDi_RSA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTepKyDuocGuiDi_RSA.Size = new System.Drawing.Size(605, 204);
            this.txtTepKyDuocGuiDi_RSA.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btKiemTraXacThuc_RSA);
            this.groupBox6.Controls.Add(this.btChonFileXacThuc_RSA);
            this.groupBox6.Controls.Add(this.txtDuongDanFileXacThuc_RSA);
            this.groupBox6.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(3, 998);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(620, 126);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kiểm tra xác thực file";
            // 
            // btKiemTraXacThuc_RSA
            // 
            this.btKiemTraXacThuc_RSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btKiemTraXacThuc_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btKiemTraXacThuc_RSA.ForeColor = System.Drawing.Color.White;
            this.btKiemTraXacThuc_RSA.Location = new System.Drawing.Point(265, 79);
            this.btKiemTraXacThuc_RSA.Name = "btKiemTraXacThuc_RSA";
            this.btKiemTraXacThuc_RSA.Size = new System.Drawing.Size(349, 34);
            this.btKiemTraXacThuc_RSA.TabIndex = 3;
            this.btKiemTraXacThuc_RSA.Text = "Kiểm tra xác thực toàn vẹn dữ liệu";
            this.btKiemTraXacThuc_RSA.UseVisualStyleBackColor = false;
            this.btKiemTraXacThuc_RSA.Click += new System.EventHandler(this.btKiemTraXacThuc_RSA_Click);
            // 
            // btChonFileXacThuc_RSA
            // 
            this.btChonFileXacThuc_RSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btChonFileXacThuc_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChonFileXacThuc_RSA.ForeColor = System.Drawing.Color.White;
            this.btChonFileXacThuc_RSA.Location = new System.Drawing.Point(494, 39);
            this.btChonFileXacThuc_RSA.Name = "btChonFileXacThuc_RSA";
            this.btChonFileXacThuc_RSA.Size = new System.Drawing.Size(120, 34);
            this.btChonFileXacThuc_RSA.TabIndex = 2;
            this.btChonFileXacThuc_RSA.Text = "Open file";
            this.btChonFileXacThuc_RSA.UseVisualStyleBackColor = false;
            this.btChonFileXacThuc_RSA.Click += new System.EventHandler(this.btChonFileXacThuc_RSA_Click);
            // 
            // txtDuongDanFileXacThuc_RSA
            // 
            this.txtDuongDanFileXacThuc_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuongDanFileXacThuc_RSA.Location = new System.Drawing.Point(9, 39);
            this.txtDuongDanFileXacThuc_RSA.Name = "txtDuongDanFileXacThuc_RSA";
            this.txtDuongDanFileXacThuc_RSA.Size = new System.Drawing.Size(479, 33);
            this.txtDuongDanFileXacThuc_RSA.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btThoatEF_RSA);
            this.groupBox7.Controls.Add(this.btTaoChuKymoi_RSA);
            this.groupBox7.Controls.Add(this.btChonVBMoiRSA);
            this.groupBox7.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(3, 1130);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(620, 91);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hành động";
            // 
            // btThoatEF_RSA
            // 
            this.btThoatEF_RSA.BackColor = System.Drawing.Color.NavajoWhite;
            this.btThoatEF_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoatEF_RSA.ForeColor = System.Drawing.Color.Red;
            this.btThoatEF_RSA.Location = new System.Drawing.Point(494, 39);
            this.btThoatEF_RSA.Name = "btThoatEF_RSA";
            this.btThoatEF_RSA.Size = new System.Drawing.Size(120, 34);
            this.btThoatEF_RSA.TabIndex = 2;
            this.btThoatEF_RSA.Text = "Thoát";
            this.btThoatEF_RSA.UseVisualStyleBackColor = false;
            this.btThoatEF_RSA.Click += new System.EventHandler(this.btThoatEF_RSA_Click);
            // 
            // btTaoChuKymoi_RSA
            // 
            this.btTaoChuKymoi_RSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btTaoChuKymoi_RSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTaoChuKymoi_RSA.ForeColor = System.Drawing.Color.White;
            this.btTaoChuKymoi_RSA.Location = new System.Drawing.Point(230, 39);
            this.btTaoChuKymoi_RSA.Name = "btTaoChuKymoi_RSA";
            this.btTaoChuKymoi_RSA.Size = new System.Drawing.Size(258, 34);
            this.btTaoChuKymoi_RSA.TabIndex = 1;
            this.btTaoChuKymoi_RSA.Text = "Tạo mới chữ ký mã hóa";
            this.btTaoChuKymoi_RSA.UseVisualStyleBackColor = false;
            this.btTaoChuKymoi_RSA.Click += new System.EventHandler(this.btTaoChuKymoi_RSA_Click);
            // 
            // btChonVBMoiRSA
            // 
            this.btChonVBMoiRSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btChonVBMoiRSA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChonVBMoiRSA.ForeColor = System.Drawing.Color.White;
            this.btChonVBMoiRSA.Location = new System.Drawing.Point(9, 39);
            this.btChonVBMoiRSA.Name = "btChonVBMoiRSA";
            this.btChonVBMoiRSA.Size = new System.Drawing.Size(215, 34);
            this.btChonVBMoiRSA.TabIndex = 0;
            this.btChonVBMoiRSA.Text = "Chọn văn bản mới";
            this.btChonVBMoiRSA.UseVisualStyleBackColor = false;
            this.btChonVBMoiRSA.Click += new System.EventHandler(this.btChonVBMoiRSA_Click);
            // 
            // RSASignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 501);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSASignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSASignForm | BMANM06_COMP104901";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RSASignForm_FormClosing);
            this.Load += new System.EventHandler(this.RSASignForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox F_rsa_soPhiN;
        private System.Windows.Forms.TextBox F_rsa_soQ;
        private System.Windows.Forms.TextBox F_rsa_soP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox F_rsa_soE;
        private System.Windows.Forms.TextBox F_rsa_soN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox F_rsa_soD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button F_rsa_TaoKhoa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btThucHienKy_RSA;
        private System.Windows.Forms.Button btChonFileKy_RSA;
        private System.Windows.Forms.TextBox txtDuongDanFileKy_RSA;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTepKyDuocGuiDi_RSA;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btKiemTraXacThuc_RSA;
        private System.Windows.Forms.Button btChonFileXacThuc_RSA;
        private System.Windows.Forms.TextBox txtDuongDanFileXacThuc_RSA;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btThoatEF_RSA;
        private System.Windows.Forms.Button btTaoChuKymoi_RSA;
        private System.Windows.Forms.Button btChonVBMoiRSA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}