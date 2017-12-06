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
        List<Entry> Entries = new List<Entry>();

        public Main()
        {
            InitializeComponent();
            RefreshListview();
        }

        public void RefreshListview()
        {
            listView.Items.Clear();
            Entries = Storage.DeserializeEntries(DataFile);

            for (int i = 0; i < Entries.Count; i++)
            {
                ListViewItem itemName = new ListViewItem(Entries[i].Website);

                itemName.SubItems.Add(Entries[i].Username);
                itemName.SubItems.Add(Entries[i].Password);
                listView.Items.Add(itemName);
            }
        }

        private void GeneratePassword_Click(object sender, EventArgs e)
        {
            string GeneratedPassword = Guid.NewGuid().ToString("N").ToLower()
                                       .Replace("1", "").Replace("o", "").Replace("0", "")
                                       .Substring(0, 10);

            textBox3.Text = GeneratedPassword;
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            Entries.Add(new Entry(textBox2.Text, textBox3.Text, textBox1.Text));
            Storage.SerializeEntries(Entries, DataFile);
            RefreshListview();
        }

        private void CopyToClipboard(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(listView.SelectedItems[0].SubItems[2].Text);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
    }
}
