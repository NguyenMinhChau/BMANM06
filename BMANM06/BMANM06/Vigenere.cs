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
        public Vigenere()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            txtKey.Text = new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[rnd.Next(s.Length)]).ToArray()).ToString();
        }
        //HÀM MÃ HÓA
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
            if(txtPlainText.Text != "" && txtKey.Text != "")
            {
                StringBuilder s = new StringBuilder(txtPlainText.Text);
                VigenereEncrypt(ref s, txtKey.Text);
                txtCiphertext.Text = s.ToString();
            }
        }
        ///HÀM GIẢI MÃ
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
                StringBuilder s = new StringBuilder(txtCiphertext.Text);
                VigenereDecrypt(ref s, txtKey.Text);
                txtDecrypt.Text = s.ToString().ToLower();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
            txtPlainText.Text = "";
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
    }
}
