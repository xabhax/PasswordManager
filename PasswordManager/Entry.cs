using System;
using System.Collections.Generic;

namespace PasswordManager
{
    [Serializable]
    sealed public class Entry
    {
        public string Username;
        public string Password;
        public string Website;

        /// <summary>
        /// Data type for the account information list
        /// </summary>
        /// <param name="uname">Username</param>
        /// <param name="pword">Password</param>
        /// <param name="site">Website</param>
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
