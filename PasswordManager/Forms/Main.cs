using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PasswordManager
{
    public partial class Main : Form
    {
        string DataFile = "C:\\users\\xabha\\Desktop\\PasswordDatabase.txt";

        public Main()
        {
            InitializeComponent();
            List<Entry> Entries = Storage.DeserializeEntries(DataFile);

            for (int i = 0; i < Entries.Count; i++)
            {
                ListViewItem itemName = new ListViewItem(Entries[i].Website);
                itemName.Tag = i;
                itemName.SubItems.Add(Entries[i].Website);
                itemName.SubItems.Add(Entries[i].Username);
                itemName.SubItems.Add(Entries[i].Password);
                listView.Items.Add(itemName);
            }
        }

        private void GeneratePassword_Click(object sender, EventArgs e)
        {

        }

        private void AddAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
