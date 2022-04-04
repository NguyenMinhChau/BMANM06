using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMANM06
{
    public partial class RSADecryptForm : Form
    {
        public RSADecryptForm()
        {
            InitializeComponent();
            rd_tdRSA.Checked = true;
            rd_tcRSA.Checked = false;
            rsa_maHoaBanRoMoi.Enabled = false;
        }
        #region Code mã hóa RSA
        private void reset_rsa()
        {
            rsa_soP.Text = rsa_soQ.Text = rsa_soPhiN.Text = rsa_soN.Text = rsa_soE.Text = rsa_soD.Text = string.Empty;

        }
        int RSA_soP, RSA_soQ, RSA_soN, RSA_soE, RSA_soD, RSA_soPhi_n;
        public int RSA_d_dau = 0;
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

        private void rsa_TaoKhoa_Click(object sender, EventArgs e)
        {
            if (rd_tdRSA.Checked == true && rd_tcRSA.Checked == false)
            {
                reset_rsa();
                RSA_soP = RSA_soQ = 0;
                do
                {
                    RSA_soP = RSA_ChonSoNgauNhien();
                    RSA_soQ = RSA_ChonSoNgauNhien();
                }
                while (RSA_soP == RSA_soQ || !RSA_kiemTraNguyenTo(RSA_soP) || !RSA_kiemTraNguyenTo(RSA_soQ));
                rsa_soP.Text = RSA_soP.ToString();
                rsa_soQ.Text = RSA_soQ.ToString();
                RSA_taoKhoa();
                RSA_d_dau = 1;
                //srsa_TaoKhoa.Text = "Tạo lại khóa mới";
                rsa_TaoKhoa.Enabled = false;
                rd_tcRSA.Enabled = false;
                rd_tdRSA.Enabled = false;
                rsa_btMaHoa.Enabled = true;
            }
            else
            {
                if (rd_tdRSA.Checked == false && rd_tcRSA.Checked == true)
                {
                    if (rsa_soP.Text == "" || rsa_soQ.Text == "")
                        MessageBox.Show("Phải nhập đủ 2 số ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        RSA_soP = int.Parse(rsa_soP.Text);
                        RSA_soQ = int.Parse(rsa_soQ.Text);
                        if (RSA_soP == RSA_soQ)
                        {
                            MessageBox.Show("Nhập 2 số nguyên tố khác nhau ", " Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rsa_soQ.Focus();
                        }
                        else
                        {
                            if (!RSA_kiemTraNguyenTo(RSA_soP) || RSA_soP <= 1)
                            {
                                MessageBox.Show("Phải nhập số nguyên  tố [p] lớn hơn 1 ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                rsa_soP.Focus();
                            }
                            else
                            {
                                if (!RSA_kiemTraNguyenTo(RSA_soQ) || RSA_soQ <= 1)
                                {
                                    MessageBox.Show("Phải nhập số nguyên  tố [q] lớn hơn 1 ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    rsa_soQ.Focus();
                                }
                                else
                                {
                                    RSA_taoKhoa();
                                    rsa_soP.Text = RSA_soP.ToString();
                                    rsa_soQ.Text = RSA_soQ.ToString();
                                    RSA_d_dau = 1;
                                    //bt_taokhoaTuychonMoi.Visible = true;
                                    rsa_TaoKhoa.Enabled = false;
                                }
                            }
                        }
                    }

                }
            }
        }

        private void rsa_btMaHoa_Click(object sender, EventArgs e)
        {
            if (RSA_d_dau != 1)
            { MessageBox.Show("Bạn chưa tạo khóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else
            {
                if (rsa_BanRo.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập bản rõ để mã hóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    // thực hiện mã hóa
                    try
                    {
                        RSA_MaHoa(rsa_BanRo.Text);
                        rsa_btMaHoa.Enabled = false;
                        rsa_btGiaiMa.Enabled = true;
                        RSA_d_dau = 2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rsa_btGiaiMa_Click(object sender, EventArgs e)
        {
            if (RSA_d_dau != 2)
                MessageBox.Show("Bạn phải tạo khóa trước ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                try
                {
                    RSA_GiaiMa(rsa_BanMaHoa.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            rsa_btGiaiMa.Enabled = false;
            RSA_d_dau = 1;
            rsa_maHoaBanRoMoi.Enabled = true;
        }

        private void rd_tdRSA_CheckedChanged(object sender, EventArgs e)
        {
            rsa_TaoKhoa.Enabled = true;
            rsa_soP.Text = rsa_soQ.Text = rsa_soPhiN.Text = rsa_soN.Text = rsa_soE.Text = rsa_soD.Text = string.Empty;
            rsa_soP.Enabled = rsa_soQ.Enabled = rsa_soPhiN.Enabled = rsa_soN.Enabled = rsa_soE.Enabled = rsa_soD.Enabled = false;
        }

        private void rd_tcRSA_CheckedChanged(object sender, EventArgs e)
        {
            rsa_TaoKhoa.Enabled = true;
            rsa_soP.Text = rsa_soQ.Text = rsa_soPhiN.Text = rsa_soN.Text = rsa_soE.Text = rsa_soD.Text = string.Empty;
            rsa_soP.Enabled = rsa_soQ.Enabled = rsa_soPhiN.Enabled = rsa_soN.Enabled = rsa_soE.Enabled = rsa_soD.Enabled = true;
        }

        private void rsa_maHoaBanRoMoi_Click(object sender, EventArgs e)
        {
            rsa_btMaHoa.Enabled = true;
            rsa_BanRo.Text = rsa_BanMaHoa.Text = rsa_banMaHoaGuiDen.Text = rsa_banGiaiMa.Text = string.Empty;
            RSA_d_dau = 1;
            rsa_maHoaBanRoMoi.Enabled = false;
        }

        private void rsa_btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void rsa_TaoKhoaMoi_Click(object sender, EventArgs e)
        {
            rsa_maHoaBanRoMoi.Enabled = false;
            RSA_d_dau = 0;
            rsa_TaoKhoa.Enabled = true;
            rd_tdRSA.Enabled = true;
            rd_tdRSA.Checked = true;
            rd_tcRSA.Enabled = true;
            rd_tcRSA.Checked = false;
            rsa_soP.Text = rsa_soQ.Text = rsa_soPhiN.Text = rsa_soN.Text = rsa_soE.Text = rsa_soD.Text = string.Empty;

            rsa_banGiaiMa.Text = rsa_BanMaHoa.Text = rsa_BanRo.Text = rsa_banMaHoaGuiDen.Text = string.Empty;
            rsa_btGiaiMa.Enabled = false; rsa_btMaHoa.Enabled = false;
        }

        private void RSADecryptForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        // "Hàm kiểm tra hai số nguyên tố cùng nhau"
        private bool RSA_nguyenToCungNhau(int ai, int bi)
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
        private void RSA_taoKhoa()
        {
            //Tinh n=p*q
            RSA_soN = RSA_soP * RSA_soQ;
            rsa_soN.Text = RSA_soN.ToString();
            //Tính Phi(n)=(p-1)*(q-1)
            RSA_soPhi_n = (RSA_soP - 1) * (RSA_soQ - 1);
            rsa_soPhiN.Text = RSA_soPhi_n.ToString();
            //Tính e là một số ngẫu nhiên có giá trị 0< e <phi(n) và là số nguyên tố cùng nhau với Phi(n)
            do
            {
                Random RSA_rd = new Random();
                RSA_soE = RSA_rd.Next(2, RSA_soPhi_n);
            }
            while (!nguyenToCungNhau(RSA_soE, RSA_soPhi_n));
            rsa_soE.Text = RSA_soE.ToString();

            //Tính d là nghịch đảo modular của e
            RSA_soD = 0;
            int i = 2;
            while (((1 + i * RSA_soPhi_n) % RSA_soE) != 0 || RSA_soD <= 0)
            {
                i++;
                RSA_soD = (1 + i * RSA_soPhi_n) / RSA_soE;
            }
            rsa_soD.Text = RSA_soD.ToString();
        }
        public void RSA_MaHoa(string ChuoiVao)
        {
            // taoKhoa();
            // Chuyen xau thanh ma Unicode
            byte[] mh_temp1 = Encoding.Unicode.GetBytes(ChuoiVao);
            string base64 = Convert.ToBase64String(mh_temp1);

            // Chuyen xau thanh ma Unicode
            int[] mh_temp2 = new int[base64.Length];
            for (int i = 0; i < base64.Length; i++)
            {
                mh_temp2[i] = (int)base64[i];
            }

            //Mảng a chứa các kí tự đã mã hóa
            int[] mh_temp3 = new int[mh_temp2.Length];
            for (int i = 0; i < mh_temp2.Length; i++)
            {
                mh_temp3[i] = RSA_mod(mh_temp2[i], RSA_soE, RSA_soN); // mã hóa
            }

            //Chuyển sang kiểu kí tự trong bảng mã Unicode
            string str = "";
            for (int i = 0; i < mh_temp3.Length; i++)
            {
                str = str + (char)mh_temp3[i];
            }
            byte[] data = Encoding.Unicode.GetBytes(str);
            rsa_BanMaHoa.Text = Convert.ToBase64String(data);
            rsa_banMaHoaGuiDen.Text = Convert.ToBase64String(data);
        }
        // hàm giải mã
        public void RSA_GiaiMa(string ChuoiVao)
        {
            byte[] temp2 = Convert.FromBase64String(ChuoiVao);
            string giaima = Encoding.Unicode.GetString(temp2);

            int[] b = new int[giaima.Length];
            for (int i = 0; i < giaima.Length; i++)
            {
                b[i] = (int)giaima[i];
            }
            //Giải mã
            int[] c = new int[b.Length];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = RSA_mod(b[i], RSA_soD, RSA_soN);// giải mã
            }

            string str = "";
            for (int i = 0; i < c.Length; i++)
            {
                str = str + (char)c[i];
            }
            byte[] data2 = Convert.FromBase64String(str);
            rsa_banGiaiMa.Text = Encoding.Unicode.GetString(data2);

        }
        #endregion
    }
}
