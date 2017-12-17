using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PasswordManager
{
    public class Storage
    {
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
