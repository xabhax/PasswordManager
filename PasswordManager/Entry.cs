﻿using System;
using System.Collections.Generic;

namespace PasswordManager
{
    [Serializable]
    public class Entry
    {
        public string Username;
        public string Password;
        public string Website;
        public string Comment;

        public Entry(string uname, string pword, string site, string comment)
        {
            this.Username = uname;
            this.Password = pword;
            this.Website = site;
            this.Comment = comment;
        }

        public Entry(string uname, string pword, string site)
        {
            this.Username = uname;
            this.Password = pword;
            this.Website = site;
        }

        public List<Entry> Entries;

        public Entry() => Entries = new List<Entry>();
    }
}
