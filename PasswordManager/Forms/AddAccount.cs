using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class AddAccount : Form
    {
        List<Entry> Entries = new List<Entry>();
        string DataFile = "C:\\users\\xabha\\Desktop\\PasswordDatabase.txt";

        public AddAccount()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e) => Entries.Add(new Entry(textbox1.Text, textbox2.Text, textbox3.Text));

        public void button2_Click(object sender, EventArgs e) => Storage.SerializeEntries(Entries, DataFile);

    }
}
