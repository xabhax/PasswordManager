using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PasswordManager
{
    public class Storage
    {
        /// <summary>
        /// Write list of accounts to database
        /// </summary>
        /// <param name="list">List containing the account information</param>
        /// <param name="fileName">Location of the database</param>
        public static void SerializeEntries(List<Entry> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));

            if (File.Exists(fileName))
            {
                using (var stream = File.OpenWrite(fileName))
                {
                    serializer.Serialize(stream, list);
                }
            }
            else
            {
                MessageBox.Show("Database doesn't exist", "PasswordManager");
            }
        }

        /// <summary>
        /// Get the account list and store it in a list
        /// </summary>
        /// <param name="fileName">Database of account information</param>
        /// <returns></returns>
        public static List<Entry> DeserializeEntries(string fileName)
        {
            var tmp = new List<Entry>();
            var serializer = new XmlSerializer(typeof(List<Entry>));

            if (File.Exists(fileName))
            {
                using (var stream = File.OpenRead(fileName))
                {
                    var other = (List<Entry>)(serializer.Deserialize(stream));
                    tmp.Clear();
                    tmp.AddRange(other);
                }
            }
            else
            {
                MessageBox.Show("Database doesn't exist", "PasswordManager");
            }
            return tmp;           
        }
    }
}
