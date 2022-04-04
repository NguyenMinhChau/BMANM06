using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMANM06
{
    public partial class RSASignForm : Form
    {
        public RSASignForm()
        {
            InitializeComponent();
            btChonFileKy_RSA.Enabled = btChonFileKy_RSA.Enabled = btChonFileXacThuc_RSA.Enabled = false;
        }

        public int danhDau = 0;

        private bool nguyenToCungNhau(int ai, int bi)// "Hàm kiểm tra hai số nguyên tố cùng nhau"
        {
            bool ktx_;
            // giải thuật Euclid;
            int temp;
            while (bi != 0)
            {
                temp = ai % bi;
                ai = bi;
                bi = temp;
            }
            if (ai == 1) { ktx_ = true; }
            else ktx_ = false;
            return ktx_;
        }
        // "Hàm lấy mod"
        public int RSA_mod(int mx, int ex, int nx)
        {

            //Sử dụng thuật toán "bình phương nhân"
            //Chuyển e sang hệ nhị phân
            int[] a = new int[100];
            int k = 0;
            do
            {
                a[k] = ex % 2;
                k++;
                ex = ex / 2;
            }
            while (ex != 0);
            //Quá trình lấy dư
            int kq = 1;
            for (int i = k - 1; i >= 0; i--)
            {
                kq = (kq * kq) % nx;
                if (a[i] == 1)
                    kq = (kq * mx) % nx;
            }
            return kq;
        }
        private int RSA_ChonSoNgauNhien()
        {
            Random rd = new Random();
            return rd.Next(11, 101);// tốc độ chậm nên chọn số bé
        }
        //"Hàm kiểm tra nguyên tố"
        private bool RSA_kiemTraNguyenTo(int xi)
        {
            bool kiemtra = true;
            if (xi == 2 || xi == 3)
            {
                // kiemtra = true;
                return kiemtra;
            }
            else
            {
                if (xi == 1 || xi % 2 == 0 || xi % 3 == 0)
                {
                    kiemtra = false;
                }
                else
                {
                    for (int i = 5; i <= Math.Sqrt(xi); i = i + 6)
                        if (xi % i == 0 || xi % (i + 2) == 0)
                        {
                            kiemtra = false;
                            break;
                        }
                }
            }
            return kiemtra;
        }

        int RSA_soP, RSA_soQ, RSA_soN, RSA_soE, RSA_soD, RSA_soPhi_n;

        private void F_rsa_TaoKhoa_Click(object sender, EventArgs e)
        {
            btChonFileKy_RSA.Enabled = btChonFileKy_RSA.Enabled = btChonFileXacThuc_RSA.Enabled = true;

            if(F_rsa_soP.Text == "" && F_rsa_soQ.Text == "")
            {
                F_reset_();
                RSA_soP = RSA_soQ = 0;
                do
                {
                    RSA_soP = RSA_ChonSoNgauNhien();
                    RSA_soQ = RSA_ChonSoNgauNhien();
                }
                while (RSA_soP == RSA_soQ || !RSA_kiemTraNguyenTo(RSA_soP) || !RSA_kiemTraNguyenTo(RSA_soQ));
                F_rsa_soP.Text = RSA_soP.ToString();
                F_rsa_soQ.Text = RSA_soQ.ToString();
                F_TaoKhoa();

                F_rsa_soPhiN.Text = RSA_soPhi_n.ToString();
                F_rsa_soE.Text = RSA_soE.ToString();
                F_rsa_soD.Text = RSA_soD.ToString();
                F_rsa_soN.Text = RSA_soN.ToString();
                F_rsa_d_dau = 1;
                F_rsa_TaoKhoa.Enabled = false;
            }
            else
            {
                if (F_rsa_soP.Text == "" || F_rsa_soQ.Text == "")
                    MessageBox.Show("Phải nhập đủ 2 số nguyên tố p và q!", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    RSA_soP = int.Parse(F_rsa_soP.Text);
                    RSA_soQ = int.Parse(F_rsa_soQ.Text);
                    if (RSA_soP == RSA_soQ)
                    {
                        MessageBox.Show("Nhập 2 số nguyên tố p và q khác nhau!", " Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        F_rsa_soQ.Focus();
                    }
                    else
                    {
                        if (!RSA_kiemTraNguyenTo(RSA_soP) || RSA_soP <= 1)
                        {
                            MessageBox.Show("Số p phải là số nguyên tố lớn hơn 1!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            F_rsa_soP.Focus();
                        }
                        else
                        {
                            if (!RSA_kiemTraNguyenTo(RSA_soQ) || RSA_soQ <= 1)
                            {
                                MessageBox.Show("Số q phải là số nguyên tố lớn hơn 1!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                F_rsa_soQ.Focus();
                            }
                            else
                            {
                                F_TaoKhoa();
                                F_rsa_soPhiN.Text = RSA_soPhi_n.ToString();
                                F_rsa_soE.Text = RSA_soE.ToString();
                                F_rsa_soD.Text = RSA_soD.ToString();
                                F_rsa_soN.Text = RSA_soN.ToString();
                                F_rsa_soP.Text = RSA_soP.ToString();
                                F_rsa_soQ.Text = RSA_soQ.ToString();
                                F_rsa_d_dau = 1;
                                F_rsa_TaoKhoa.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void btChonFileKy_RSA_Click(object sender, EventArgs e)
        {
            /////// chọn file để ký 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanFileKy_RSA.Text = openFileDialog.FileName;
            }
            btThucHienKy_RSA.Enabled = true;
        }

        private void btThoatEF_RSA_Click(object sender, EventArgs e)
        {
            //this.Close();
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btThucHienKy_RSA_Click(object sender, EventArgs e)
        {
            // thực hiên ký
            if (F_rsa_d_dau != 1)
            {
                MessageBox.Show("Bạn chưa tạo chữ ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (F_rsa_d_dau == 1)
                {
                    byte mk = byte.Parse("111");
                    if (!File.Exists(txtDuongDanFileKy_RSA.Text))
                    {
                        // MessageBox.Show("Phải nhập đủ 2 số ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Bạn chưa chọn file thực hiện ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (File.Exists(txtDuongDanFileKy_RSA.Text))
                    {
                        FileStream fsFileDauVao = new FileStream(txtDuongDanFileKy_RSA.Text, FileMode.Open);
                        SHA256 mySHA256 = SHA256Managed.Create();
                        byte[] FileVBKy_temp1 = mySHA256.ComputeHash(fsFileDauVao);

                        string FileVBKy = Convert.ToBase64String(FileVBKy_temp1);
                        string VBKemChuKy = F_MaHoa_RSA(FileVBKy);
                        txtTepKyDuocGuiDi_RSA.Text = VBKemChuKy;

                        fsFileDauVao.Close();
                        fsFileDauVao.Dispose();
                        F_rsa_d_dau = 2;
                        MessageBox.Show("Thực hiện ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btThucHienKy_RSA.Enabled = false;
                    }
                }
            }
        }

        private void btChonFileXacThuc_RSA_Click(object sender, EventArgs e)
        {
            /////// chọn file để ký xác thực
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanFileXacThuc_RSA.Text = openFileDialog.FileName;
            }
            btKiemTraXacThuc_RSA.Enabled = true;
        }

        private void btKiemTraXacThuc_RSA_Click(object sender, EventArgs e)
        {
            // thực hiên kiểm tra
            if (F_rsa_d_dau == 2)
            {
                if (!File.Exists(txtDuongDanFileXacThuc_RSA.Text))
                {
                    MessageBox.Show("Bạn chưa chọn tài liệu kiểm tra chữ ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (File.Exists(txtDuongDanFileXacThuc_RSA.Text))
                {
                    FileStream fsFileDauVao = new FileStream(txtDuongDanFileXacThuc_RSA.Text, FileMode.Open);
                    SHA256 mySHA256 = SHA256Managed.Create();
                    byte[] FileVBKy_temp2 = mySHA256.ComputeHash(fsFileDauVao);
                    string ChuoiVBdiKem_ShA = Convert.ToBase64String(FileVBKy_temp2);

                    string VBKemChuKyGM = F_GiaiMa_RSA(txtTepKyDuocGuiDi_RSA.Text); // thực hiện giải mã chữ ký
                    //txtChuKySoGiaiMa.Text = VBKemChuKyGM;     
                    int result = 0;

                    result = string.Compare(VBKemChuKyGM, ChuoiVBdiKem_ShA, true);

                    if (result == 0)
                    {
                        MessageBox.Show("Tài liệu gửi đến không bị chỉnh sửa gì!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btKiemTraXacThuc_RSA.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Tài liệu gửi đến đã bị thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btKiemTraXacThuc_RSA.Enabled = false;
                    }
                    fsFileDauVao.Close();
                    fsFileDauVao.Dispose();

                }
            }
            else
            {
                MessageBox.Show("Chưa thực hiện ký và gửi file ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btKiemTraXacThuc_RSA.Enabled = false;
            }
        }

        private void btChonVBMoiRSA_Click(object sender, EventArgs e)
        {
            txtDuongDanFileXacThuc_RSA.Text = txtDuongDanFileKy_RSA.Text = txtTepKyDuocGuiDi_RSA.Text = string.Empty;
            F_rsa_d_dau = 1;
        }

        private void btTaoChuKymoi_RSA_Click(object sender, EventArgs e)
        {
            txtDuongDanFileXacThuc_RSA.Text = txtDuongDanFileKy_RSA.Text = txtTepKyDuocGuiDi_RSA.Text = string.Empty;
            F_rsa_d_dau = 0;
            F_reset_();
            F_rsa_TaoKhoa.Enabled = true;
        }

        private void RSASignForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void RSASignForm_Load(object sender, EventArgs e)
        {
            F_rsa_soPhiN.Enabled = F_rsa_soN.Enabled = F_rsa_soE.Enabled = F_rsa_soD.Enabled = false;
        }

        #region Code chữ ký RSA
        private void F_TaoKhoa()
        {
            //Tinh n=p*q
            RSA_soN = RSA_soP * RSA_soQ;
            //Tính Phi(n)=(p-1)*(q-1)
            RSA_soPhi_n = (RSA_soP - 1) * (RSA_soQ - 1);
            //Tính e là một số ngẫu nhiên có giá trị 0< e <phi(n) và là số nguyên tố cùng nhau với Phi(n)
            do
            {
                Random RSA_rd = new Random();
                RSA_soE = RSA_rd.Next(2, RSA_soPhi_n);
            }
            while (!nguyenToCungNhau(RSA_soE, RSA_soPhi_n));
            //Tính d là nghịch đảo modular của e
            RSA_soD = 0;
            int i = 2;
            while (((1 + i * RSA_soPhi_n) % RSA_soE) != 0 || RSA_soD <= 0)
            {
                i++;
                RSA_soD = (1 + i * RSA_soPhi_n) / RSA_soE;
            }
        }
        private void F_reset_()
        {
            F_rsa_soP.Text = F_rsa_soQ.Text = F_rsa_soPhiN.Text = F_rsa_soN.Text = F_rsa_soE.Text = F_rsa_soD.Text = string.Empty;
        }
        int F_rsa_d_dau = 0;
        // hàm mã hóa
        public string F_MaHoa_RSA(string ChuoiVao1)
        {
            byte[] F_mh_temp1 = Encoding.Unicode.GetBytes(ChuoiVao1);
            string F_base64 = Convert.ToBase64String(F_mh_temp1);

            // Chuyen xau thanh ma Unicode
            int[] F_mh_temp2 = new int[F_base64.Length];
            for (int i = 0; i < F_base64.Length; i++)
            {
                F_mh_temp2[i] = (int)F_base64[i];
            }

            //Mảng a chứa các kí tự đã mã hóa
            int[] F_mh_temp3 = new int[F_mh_temp2.Length];
            for (int i = 0; i < F_mh_temp2.Length; i++)
            {
                F_mh_temp3[i] = RSA_mod(F_mh_temp2[i], RSA_soE, RSA_soN); // mã hóa
            }

            //Chuyển sang kiểu kí tự trong bảng mã Unicode
            string Fmh_str = "";
            for (int i = 0; i < F_mh_temp3.Length; i++)
            {
                Fmh_str = Fmh_str + (char)F_mh_temp3[i];
            }

            byte[] Fmh_data = Encoding.Unicode.GetBytes(Fmh_str);
            string F_ChuoiVBkemChuky = string.Empty;
            F_ChuoiVBkemChuky = Convert.ToBase64String(Fmh_data);
            return F_ChuoiVBkemChuky;
        }
        // hàm giải mã
        public string F_GiaiMa_RSA(string F_ChuoiVao2)
        {
            byte[] Fgm_temp1 = Convert.FromBase64String(F_ChuoiVao2);
            string Fgm_giaima = Encoding.Unicode.GetString(Fgm_temp1);

            int[] Fgm_temp2 = new int[Fgm_giaima.Length];
            for (int i = 0; i < Fgm_giaima.Length; i++)
            {
                Fgm_temp2[i] = (int)Fgm_giaima[i];
            }
            //Giải mã
            int[] Fgm_temp3 = new int[Fgm_temp2.Length];
            for (int i = 0; i < Fgm_temp3.Length; i++)
            {
                Fgm_temp3[i] = RSA_mod(Fgm_temp2[i], RSA_soD, RSA_soN);// giải mã
            }

            string Fgm_str2 = "";
            for (int i = 0; i < Fgm_temp3.Length; i++)
            {
                Fgm_str2 = Fgm_str2 + (char)Fgm_temp3[i];
            }
            byte[] F_gm_data2 = Convert.FromBase64String(Fgm_str2);

            string F_GM_ChuoiVBkemChuky = string.Empty;
            F_GM_ChuoiVBkemChuky = Encoding.Unicode.GetString(F_gm_data2);
            return F_GM_ChuoiVBkemChuky;
        }
        #endregion
    }
}
