using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BMANM06
{
    public partial class RSA : Form
    {
        private delegate void btnEncryptDecrypt();

        private RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        private string pathKeysXML = "";
        private bool isEncryptFile = true;
        byte[] plaintText;
        byte[] cipherText;
        public RSA()
        {
            InitializeComponent();
        }
        private void RSA_Load_1(object sender, EventArgs e)
        {
            this.cbKeyLength.Items.Add("512 bits");
            this.cbKeyLength.Items.Add("1024 bits");
            this.cbKeyLength.Items.Add("2048 bits");
            this.cbKeyLength.Items.Add("4096 bits");
            this.txtModule.Enabled = false;
            this.txtMuGiaiMa.Enabled = false;
            this.txtMuMaHoa.Enabled = false;
            txtMD5.Enabled = false;
            txtSHA1.Enabled = false;
            txtSHA256.Enabled = false;
            this.cbKeyLength.Text = "1024 bits";
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void RSA_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void enabledOrDisableButtons(bool isEnable)
        {
            this.btnReset.Enabled = isEnable;
            this.btnOpenFolder.Enabled = isEnable;
            this.txtOutput.Enabled = isEnable;
            this.btnEncrypt.Enabled = isEnable;
            this.btnDecrypt.Enabled = isEnable;
            this.btnGenerateKeyAuto.Enabled = isEnable;
            this.btnSelectFile.Enabled = isEnable;
            this.btnOpenFile.Enabled = isEnable;
            this.btnSelectFolder.Enabled = isEnable;
            this.btnSelectFolderOut.Enabled = isEnable;


        }

        private void btnGenerateKeyAuto_Click(object sender, EventArgs e)
        {
            // Tạo file chứa key
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "Xml File|*.xml|All File|*.*";
            saveFileDialog1.Title = "Chọn tên file";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            int lengthKey = 0;
            if (this.cbKeyLength.Text == "1024 bits") lengthKey = 1024;
            else if (this.cbKeyLength.Text == "512 bits") lengthKey = 512;
            else if (this.cbKeyLength.Text == "2048 bits") lengthKey = 2048;
            else if (this.cbKeyLength.Text == "4096 bits") lengthKey = 4096;
            saveFileDialog1.RestoreDirectory = true;
            String pathPrivateKey = saveFileDialog1.FileName;
            //tạo key có độ dài lengthKey
            rsa = new RSACryptoServiceProvider(lengthKey); //tạo key có độ dài lengtheKey


            File.WriteAllText(pathPrivateKey, rsa.ToXmlString(true));  // Private Key

            pathKeysXML = pathPrivateKey;
            txtFileKey.Text = pathPrivateKey; //Hiển thị đường dẫn key

            if (File.Exists(pathKeysXML))
            {
                if (Path.GetExtension(pathKeysXML) == ".xml") //kiểm tra định dạng
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeysXML)); //đọc RSA Key
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        txtModule.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        txtMuMaHoa.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        txtMuGiaiMa.Text = xnList.InnerText;
                        txtModule.Enabled = true;
                        txtMuMaHoa.Enabled = true;
                        txtMuGiaiMa.Enabled = true;
                    }
                    catch (Exception ix)
                    {
                        MessageBox.Show(ix.Message);
                    }
                }
            }
            MessageBox.Show("Tạo key có độ dài " + lengthKey.ToString() + " bits thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            this.txtMuGiaiMa.Clear(); this.txtMuMaHoa.Clear(); this.txtModule.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pathKeysXML = op.FileName;
                txtFileKey.Text = op.FileName;
            }

            if (File.Exists(pathKeysXML))
            {

                if (Path.GetExtension(pathKeysXML) == ".xml")
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeysXML));
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        txtModule.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        txtMuMaHoa.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        txtMuGiaiMa.Text = xnList.InnerText;
                        txtModule.Enabled = true;
                        txtMuMaHoa.Enabled = true;
                        txtMuGiaiMa.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            isEncryptFile = true;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                txtInput.Text = op.FileName;
        }

        private void btnOpenFolder_Click_1(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                try
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = txtOutput.Text;
                    prc.Start();
                }
                catch (Exception ioex)
                {
                    MessageBox.Show("Failed: " + ioex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đường dẫn !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
        {
            try
            {
                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read); //Đọc file input
                FileStream fsCiperText = new FileStream(outputFile, FileMode.Create, FileAccess.Write); //Tạo file output
                fsCiperText.SetLength(0);
                byte[] bin, encryptedData;
                long rdlen = 0;
                long totlen = fsInput.Length;
                int len;
                this.progressBarEnDe.Minimum = 0;
                this.progressBarEnDe.Maximum = 100;

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.ImportParameters(RSAKeyInfo); //Nhập thông tin khoá RSA (bao gồm khoá riêng)

                int maxBytesCanEncrypted;
                //RSA chỉ có thể mã hóa các khối dữ liệu ngắn hơn độ dài khóa, chia dữ liệu cho một số khối và sau đó mã hóa từng khối và sau đó hợp nhất chúng
                if (isEncrypt)
                    maxBytesCanEncrypted = ((RSA.KeySize - 384) / 8) + 37;// + 7: OAEP - Đệm mã hóa bất đối xứng tối ưu

                else
                    maxBytesCanEncrypted = (RSA.KeySize / 8);
                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    if (totlen - rdlen < maxBytesCanEncrypted) maxBytesCanEncrypted = (int)(totlen - rdlen);
                    bin = new byte[maxBytesCanEncrypted];
                    len = fsInput.Read(bin, 0, maxBytesCanEncrypted);

                    if (isEncrypt) encryptedData = RSA.Encrypt(bin, false); //Mã Hoá
                    else encryptedData = RSA.Decrypt(bin, false); //Giải mã

                    fsCiperText.Write(encryptedData, 0, encryptedData.Length);
                    rdlen = rdlen + len;

                    this.labelNotifiupdate.Text = "Tên tệp xử lý : " + Path.GetFileName(inputFile) + "\t Thành công: " + ((long)(rdlen * 100) / totlen).ToString() + " %";
                    this.labelNotifiupdate.Update();
                    this.labelNotifiupdate.Refresh();

                    this.progressBarEnDe.Value = (int)((rdlen * 100) / totlen);//thanh tiến trình
                }

                fsCiperText.Close(); //save file
                fsInput.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEncryptClick()
        {
            enabledOrDisableButtons(false);
            if (this.txtFileKey.Text.Length == 0 || this.txtModule.Text.Length == 0 || this.txtMuGiaiMa.Text.Length == 0 || this.txtMuMaHoa.Text.Length == 0)
            {
                MessageBox.Show("Key không hợp lệ!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                enabledOrDisableButtons(true);
                return;
            }

            try
            {
                if (txtInput.Text.Length != 0 &&
                txtFileKey.Text.Length != 0 &&
                txtModule.Text.Length != 0)
                {

                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    string inputFileName = txtInput.Text, outputFileName = "";

                    if (isEncryptFile)
                    {
                        outputFileName = txtOutput.Text + "\\" + Path.GetFileName(txtInput.Text) + ".lhde";
                    }
                    //get Keys.
                    rsa = new RSACryptoServiceProvider();
                    rsa.FromXmlString(File.ReadAllText(this.pathKeysXML));
                    if (isEncryptFile)
                        RSA_Algorithm(inputFileName, outputFileName, rsa.ExportParameters(true), true);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*");

                        if (filePaths.Length == 0 || (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db")))
                        {
                            MessageBox.Show("Thư mục rỗng!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            enabledOrDisableButtons(true);
                            return;
                        }



                        // tbt.Text = Path.GetDirectoryName(outputFileName);
                        for (int i = 0; i < filePaths.Length; i++)
                        {
                            outputFileName = txtOutput.Text + "\\" + Path.GetFileName(filePaths[i]);
                            if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                                RSA_Algorithm(filePaths[i], outputFileName + ".lhde", rsa.ExportParameters(true), true);
                        }
                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Thời gian thực thi " + elapsedMs.ToString() + "s","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    enabledOrDisableButtons(true);
                    MessageBox.Show("Dữ liệu không đủ để mã hóa!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                enabledOrDisableButtons(true);
                MessageBox.Show("Failed: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enabledOrDisableButtons(true);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtFileKey.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến Key!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnEncryptClick();
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnEncryptClick);
            //s.BeginInvoke(null, null);
        }
        private void btnDecryptClick()
        {
            enabledOrDisableButtons(false);

            try
            {
                if (txtInput.Text.Length != 0 &&
                   txtFileKey.Text.Length != 0 &&
                   txtModule.Text.Length != 0)
                {
                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();

                    string inputFileName = txtInput.Text, outputFileName = "";

                    if (isEncryptFile && Path.GetExtension(inputFileName) != ".lhde")
                    {
                        MessageBox.Show("Tệp tin này không được hỗ trợ đển giải mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enabledOrDisableButtons(true);
                        return;
                    }

                    if (isEncryptFile)
                    {

                        outputFileName = txtOutput.Text + "\\" + Path.GetFileName(inputFileName.Substring(0, inputFileName.Length - 5));


                    }

                    rsa = new RSACryptoServiceProvider();
                    rsa.FromXmlString(File.ReadAllText(this.pathKeysXML));

                    if (isEncryptFile)
                        RSA_Algorithm(inputFileName, outputFileName, rsa.ExportParameters(true), false);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*.lhde", SearchOption.AllDirectories);
                        if (filePaths.Length == 0 || (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db")))
                        {
                            MessageBox.Show("Thư mục rỗng!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            enabledOrDisableButtons(true);
                            return;
                        }

                        for (int i = 0; i < filePaths.Length; i++)
                            if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                            {
                                outputFileName = txtOutput.Text + "\\" + Path.GetFileName(filePaths[i].Substring(0, filePaths[i].Length - 5));
                                RSA_Algorithm(filePaths[i], outputFileName, rsa.ExportParameters(true), false);

                            }

                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Tổng thời gian thực thi: " + elapsedMs.ToString() + "s", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không đủ điều kiện để giải mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enabledOrDisableButtons(true);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnDecryptClick();
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnDecryptClick);
            //s.BeginInvoke(null, null);
        }

        private void btnSelectFolder_Click_1(object sender, EventArgs e)
        {
            isEncryptFile = false;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.txtInput.Text = folderBrowserDialog1.SelectedPath;
        }
        public static string MD5(string path)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

        public static string SHA1(string path)
        {
            using (var cryptoProvider = new SHA1CryptoServiceProvider())
            {
                var stream = File.OpenRead(path);
                string hash = BitConverter
                    .ToString(cryptoProvider.ComputeHash(stream)).Replace("-", "");
                return hash.ToLower();
            }
        }

        public static string SHA256(string path)
        {
            using (FileStream stream = File.OpenRead(path))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] hash = sha.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtFileKiemtra.Text != "")
            {
                txtMD5.Text = MD5(txtFileKiemtra.Text);
                txtSHA1.Text = SHA1(txtFileKiemtra.Text);
                txtSHA256.Text = SHA256(txtFileKiemtra.Text);
                txtMD5.Enabled = true;
                txtSHA1.Enabled = true;
                txtSHA256.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileKiemtra.Text = dialog.FileName;
                }
            }
        }

        private void btnSelectFolderOut_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                this.txtOutput.Text = f1.SelectedPath;
            }
        }

        private void btnEncryptString_Click_1(object sender, EventArgs e)
        {
            if (txtPlainTextString.Text != "")
            {
                plaintText = Encoding.UTF8.GetBytes(txtPlainTextString.Text);
                cipherText = RSAEncryptionString.MaHoa(plaintText,
                rsa.ExportParameters(false), false);
                //txtCipherText.Text =
                Encoding.UTF8.GetString(cipherText);
                StringBuilder sbHash = new StringBuilder();
                foreach (byte b in cipherText)
                    sbHash.Append(String.Format("{0:x2}", b));
                txtCiphertextString.Text = sbHash.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chuỗi cần mã hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecryptString_Click(object sender, EventArgs e)
        {
            if (txtCiphertextString.Text != "")
            {
                byte[] decryptText = RSAEncryptionString.GiaiMa(cipherText, rsa.ExportParameters(true), false);
                txtPlainTextStringDecrypt.Text = Encoding.UTF8.GetString(decryptText);
            }
            else
            {
                MessageBox.Show("Vui lòng mã hóa chuỗi bất kì trước khi giải mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMD5.Enabled = false;
            txtSHA1.Enabled = false;
            txtSHA256.Enabled = false;
            this.isEncryptFile = true;
            this.txtFileKey.Clear();
            this.txtInput.Clear();
            this.txtModule.Clear();
            this.txtMuGiaiMa.Clear();
            this.txtMuMaHoa.Clear();
            txtModule.Enabled = false;
            txtMuMaHoa.Enabled = false;
            txtMuGiaiMa.Enabled = false;
            txtFileKiemtra.Clear();
            txtMD5.Clear();
            txtSHA1.Clear();
            txtSHA256.Clear();
            txtPlainTextString.Text = "";
            txtCiphertextString.Text = "";
            txtPlainTextStringDecrypt.Text = "";

            this.txtOutput.Clear();
            this.pathKeysXML = "";
            this.cbKeyLength.Text = "1024 bits";
            this.labelNotifiupdate.Text = "";
            this.labelNotifiupdate.Update();
            rsa = new RSACryptoServiceProvider();
            if (this.progressBarEnDe.Value > 0)
                this.progressBarEnDe.Value = 0;
        }
    }
}
