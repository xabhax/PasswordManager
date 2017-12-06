using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PasswordManager
{
    [Serializable]
    public class Entry
    {
        public string Username;
        public string Password;
        public string Website;

        public Entry(string uname, string pword, string site)
        {
            this.Username = uname;
            this.Password = pword;
            this.Website = site;
        }

        public List<Entry> Entries;

        public Entry()
        {
            Entries = new List<Entry>();
        }
    }
}
