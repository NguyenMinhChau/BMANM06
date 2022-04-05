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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RSA();
            form.Show();
        }

        private void vigenereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Vigenere();
            form.Show();
        }

        private void RSADecrypt_Click(object sender, EventArgs e)
        {
            var form = new RSADecryptForm();
            form.Show();
        }

        private void RSAChuKySo_Click(object sender, EventArgs e)
        {
            var form = new RSASignForm();
            form.Show();
        }

        private void aboutRSA_Click(object sender, EventArgs e)
        {
            var form = new AboutRSAForm();
            form.Show();
        }

        private void aboutVigenere_Click(object sender, EventArgs e)
        {
            var form = new AboutVigenereForm();
            form.Show();
        }
    }
}
