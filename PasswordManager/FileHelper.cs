using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class FileHelper
    {
        /// <summary>
        /// Checks if the account database is valid based upon the md5 stored in the registry
        /// </summary>
        /// <param name="fileName">Location of the account database</param>
        /// <returns>True</returns>
        public static bool IsDatabaseValid(string fileName)
        {
            string StoredMD5 = RegistryHelper.GetKey("MD5");
            string CalculatedMD5 = CalculateMD5(RegistryHelper.Datafile);

            return (StoredMD5 == CalculatedMD5) ? true : false;
        }

        /// <summary>
        /// Calculates md5 for a given file
        /// </summary>
        /// <param name="filename">Filename to get md5 has</param>
        /// <returns>The calculated hash of the file given</returns>
        private static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        /// <summary>
        /// Encrypts the account database
        /// </summary>
        /// <param name="fileName">Location of the database</param>
        /// <param name="key">Key to encrypt the database</param>
        public static void EncryptDatabase(string fileName, string key)
        {

        }

        /// <summary>
        /// Decrypts the account database
        /// </summary>
        /// <param name="fileName">Location of the database</param>
        /// <param name="key">Key to decrypt the password</param>
        public static void DecryptDatabase(string fileName, string key)
        {

        }
    }
}
