
namespace BMANM06
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vigenereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RSADecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.RSAChuKySo = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSAToolStripMenuItem,
            this.vigenereToolStripMenuItem,
            this.RSADecrypt,
            this.RSAChuKySo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // vigenereToolStripMenuItem
            // 
            this.vigenereToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.vigenereToolStripMenuItem.Name = "vigenereToolStripMenuItem";
            this.vigenereToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.vigenereToolStripMenuItem.Text = "Vigenere ";
            this.vigenereToolStripMenuItem.Click += new System.EventHandler(this.vigenereToolStripMenuItem_Click);
            // 
            // RSADecrypt
            // 
            this.RSADecrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RSADecrypt.Name = "RSADecrypt";
            this.RSADecrypt.Size = new System.Drawing.Size(137, 27);
            this.RSADecrypt.Text = "RSA Mã Hóa";
            this.RSADecrypt.Click += new System.EventHandler(this.RSADecrypt_Click);
            // 
            // RSAChuKySo
            // 
            this.RSAChuKySo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RSAChuKySo.Name = "RSAChuKySo";
            this.RSAChuKySo.Size = new System.Drawing.Size(160, 27);
            this.RSAChuKySo.Text = "RSA Chữ Ký Số";
            this.RSAChuKySo.Click += new System.EventHandler(this.RSAChuKySo_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Items.AddRange(new object[] {
            "1. NGUYỄN MINH CHÂU \t-  \t4501104023",
            "2. HỒ THỊ MỸ DUNG \t- \t4501104034",
            "3. NGUYỄN TUYẾT NGÂN \t-\t4501104154",
            "4. NGUYỄN DUY PHÚC \t- \t4501104179",
            "5. VÕ THỊ TRÚC PHƯƠNG \t- \t4501104185",
            "6. PHẠM THANH QUAN \t- \t4501104188"});
            this.listBox1.Location = new System.Drawing.Point(12, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 301);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(172, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH NHÓM BMANM06 - COMP104901";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuật toán mã hóa RSA & Vigenere | BMANM06_COMP104901 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vigenereToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem RSADecrypt;
        private System.Windows.Forms.ToolStripMenuItem RSAChuKySo;
        private System.Windows.Forms.Label label1;
    }
}

