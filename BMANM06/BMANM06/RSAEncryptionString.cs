using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMANM06
{
    public class RSAEncryptionString
    {
        public static byte[] MaHoa(byte[] dulieu, RSAParameters RSAKey, bool doOAEF)
        {
            try
            {
                RSACryptoServiceProvider rsa = new
                RSACryptoServiceProvider();
                rsa.ImportParameters(RSAKey);
                return rsa.Encrypt(dulieu, doOAEF);
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static byte[] GiaiMa(byte[] dulieu, RSAParameters RSAKey, bool doOAEF)
        {
            try
            {
                RSACryptoServiceProvider rsa = new
                RSACryptoServiceProvider();
                rsa.ImportParameters(RSAKey);
                return rsa.Decrypt(dulieu, doOAEF);
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
