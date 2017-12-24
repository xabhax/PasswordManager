using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace PasswordManager
{
    class ZipHelper
    {
        public void CreateArchive()
        {

        }

        /// <summary>
        /// Opens data container and reads the hashed password 
        /// </summary>
        /// <returns>Returns the hash of the encrypted password</returns>
        public static string RetrievePassword()
        {
            string zipFileFullPath = RegistryHelper.Zipfile;
            string targetFileName = "Keyfile.pm";
            string text = new string(
                        (new StreamReader(
                         ZipFile.OpenRead(zipFileFullPath)
                         .Entries.Where(x => x.Name.Equals(targetFileName,StringComparison.InvariantCulture))
                         .FirstOrDefault()
                         .Open(), Encoding.UTF8)
                         .ReadToEnd())
                         .ToArray());
            return text;
        }
        public static void ExtractArchive()
        {

        }
    }
}
