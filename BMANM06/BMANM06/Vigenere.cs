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
    public partial class Vigenere : Form
    {
        public string key { get; set; }
        public string plainText { get; set; }
        public string cipherText { get; set; }
        public Vigenere()
        {
            InitializeComponent();
        }

        //AÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆGHIÍÌỈĨỊKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴ !?.,;:-
        string chuoi = "FWZAÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆGHIÍÌỈĨỊKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴ !?.,;:-";

        public int[] chuoi_mangchiso(string s)
        {
            int[] mang = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                mang[i] = chuoi.IndexOf(s[i]);
            return mang;
        }
        public string chiso_chuoi(int[] a)
        {
            string s = "";
            for (int i = 0; i < a.Length; i++)
                s += chuoi[a[i]];
            return s;
        }

        private void Vigenere_Load(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            txtKey.Enabled = false;
            txtKey.Text = "Nhập PlainText -> Thực hiện generate key...";
            LengthKey.Text = "---";
            btnMaHoa.Enabled = false;
            btnDecrypt.Enabled = false;
        }

        private void txtPlainText_TextChanged(object sender, EventArgs e)
        {
           if(txtPlainText.Text.Length <= 0)
            {
                btnMaHoa.Enabled = false;
                btnGenerate.Enabled = false;
            }
            else
            {
                btnMaHoa.Enabled = true;
                btnGenerate.Enabled = true;
            }
            LengthPlainText.Text = "Độ dài PlainText: " + txtPlainText.Text.Length + " kí tự.";
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            LengthKey.Text = "Độ dài Key: " + txtKey.Text.Length + " kí tự.";
        }

        private void txtPlainText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else
                e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void txtCiphertext_TextChanged(object sender, EventArgs e)
        {
            if (txtCiphertext.Text.Length <= 0)
            {
                btnDecrypt.Enabled = false;
            }
            else
            {
                btnDecrypt.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRTUSVWXYZ";
            txtKey.Text = new string(Enumerable.Repeat(chars, txtPlainText.Text.Length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray()).ToString().ToUpper();

        }

        #region HÀM MÃ HÓA
        //----------------------------
        public String MaHoa()
        {
            plainText = plainText.ToUpper();
            int[] p = chuoi_mangchiso(plainText);
            int[] k = chuoi_mangchiso(key);
            int[] kq = new int[plainText.Length];
            for (int i = 0, j = 0; i < plainText.Length; i++)
            {
                kq[i] = (p[i] + k[j]) % chuoi.Length;
                j = ++j % k.Length;
            }
            cipherText = chiso_chuoi(kq);
            return cipherText;
        }
        //----------------------------------
        static void VigenereEncrypt(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = (char)(s[i] + key[j] - 'A');
                    if (s[i] > 'Z') s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (txtPlainText.Text != "" && txtKey.Text != "" && txtKey.Text.Length >= txtPlainText.Text.Length)
            {
                /*txtPlainText.Text = txtPlainText.Text.ToUpper();
                StringBuilder s = new StringBuilder(txtPlainText.Text);
                VigenereEncrypt(ref s, txtKey.Text);
                txtCiphertext.Text = s.ToString().ToUpper();*/
                key = txtKey.Text.ToUpper();
                plainText = txtPlainText.Text.ToUpper();
                txtCiphertext.Text = MaHoa();

            }
            if (txtKey.Text.Length < txtPlainText.Text.Length) {
                MessageBox.Show("Vui lòng nhập KEY có độ dài bằng độ dài của chuỗi cần mã hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPlainText.Text == "" || txtKey.Text == "")
            {
                MessageBox.Show("Khóa hoặc chuỗi mã hóa chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region HÀM GIẢI MÃ
        //----------------------------------
        public String GiaiMa()
        {
            int[] c = chuoi_mangchiso(cipherText);
            int[] k = chuoi_mangchiso(key);
            int[] kq = new int[cipherText.Length];
            for (int i = 0, j = 0; i < cipherText.Length; i++)
            {
                kq[i] = (c[i] - k[j]) % chuoi.Length;
                if (kq[i] < 0)
                    kq[i] = (c[i] + (chuoi.Length - k[j])) % chuoi.Length;
                j = ++j % k.Length;
            }
            plainText = chiso_chuoi(kq);
            return plainText;
        }
        //--------------------------------------
        static void VigenereDecrypt(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                              (char)(s[i] - key[j] + 'A') :
                              (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if(txtCiphertext.Text != "")
            {
                /*txtCiphertext.Text = txtCiphertext.Text.ToUpper();
                StringBuilder s = new StringBuilder(txtCiphertext.Text);
                VigenereDecrypt(ref s, txtKey.Text);
                txtDecrypt.Text = s.ToString().ToUpper();*/
                key = txtKey.Text.ToUpper();
                cipherText = txtCiphertext.Text.ToUpper();
                txtDecrypt.Text = GiaiMa();
            }
            else
            {
                MessageBox.Show("Vui lòng mã hóa chuỗi bất kì trước khi giải mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKey.Text = "Nhập PlainText -> Thực hiện generate key...";
            LengthKey.Text = "";
            txtPlainText.Text = "";
            LengthPlainText.Text = "";
            txtCiphertext.Text = "";
            txtDecrypt.Text = "";
        }

        private void Vigenere_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtKey_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
