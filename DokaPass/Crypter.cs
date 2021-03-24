using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DokaPass
{
    public class Crypter
    {
        private static string Key()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            string key;

            if (!File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\keys\\" + "key.xml"))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\keys");
                StreamWriter SavePublicKey = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\keys\\" + "key.xml");
                SavePublicKey.Write(key = (RSA.ToXmlString(true)));
                SavePublicKey.Close();
            }

            else
            {
                StreamReader OpenPublicKey = new StreamReader(Path.GetDirectoryName(Application.ExecutablePath) + "\\keys\\" + "key.xml");
                key = OpenPublicKey.ReadToEnd();
                OpenPublicKey.Close();
            }

            return key;
        }




        public static string Encrypt(string text)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            try
            {
                byte[] encryptedData;
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(Key());
                encryptedData = RSA.Encrypt(ByteConverter.GetBytes(text), false);
                return Convert.ToBase64String(encryptedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static string Decrypt(string text)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            try
            {
                byte[] decryptedData;
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(Key());
                decryptedData = RSA.Decrypt(Convert.FromBase64String(text), false);
                return ByteConverter.GetString(decryptedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
