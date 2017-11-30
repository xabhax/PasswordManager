using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace PasswordManager
{
    public class Crypto
    {
        /// <summary>
        /// Encrypt text
        /// </summary>
        /// <param name="clearText">txt you want to encrypt</param>
        /// <returns></returns>
        public static string EncryptText(string clearText)
        {
            string EncryptionKey = "Ab41Dyy2Hm1dR98hEl";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        /// <summary>
        /// Decrypt text
        /// </summary>
        /// <param name="cipherText">text you want to decrypt</param>
        /// <returns></returns>
        public static string DecryptText(string cipherText)
        {
            string EncryptionKey = "Ab41Dyy2Hm1dR98hEl";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        /// <summary>
        /// Checks passed arguments against stored encrypted strings in registry
        /// </summary>
        /// <param name="Username">plain text username</param>
        /// <param name="Password">plain text passwod</param>
        /// <returns></returns>
        public static bool CheckLoginCredentials(string Username, string Password)
        {
            string x = DecryptText(Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Username", null).ToString());
            string y = DecryptText(Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Password", null).ToString());

            if (Username == x && Password == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }    
}
