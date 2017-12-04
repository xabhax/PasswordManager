using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PasswordManager
{
    public static class Storage
    {
        public static void SerializeEntries(List<Entry> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));
            using (var stream = File.OpenWrite(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }
        public static void DeserializeEntries(this List<Entry> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<Entry>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }
    }
}
