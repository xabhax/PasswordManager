using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class TestMain : Form
    {
        string DataFile = "C:\\users\\xabha\\Desktop\\PasswordDatabase.txt";
        List<Entry> Entries = new List<Entry>();

        public TestMain()
        {
            InitializeComponent();
            ClearAllButtonSelectPanels();
            ClearAllMainPanels();
        }
        private void ClearAllButtonSelectPanels()
        {
            AddAccountButtonSelected.Visible = false;
            ViewAccountsButtonSelected.Visible = false;
            EditAccountButtonSelected.Visible = false;
            SettingsButtonSelected.Visible = false;
            LoadDatabaseButtonSelected.Visible = false;
            SaveDatabaseButtonSelected.Visible = false;
            QuitButtonSelected.Visible = false;
        }

        private void ClearAllMainPanels()
        {
            ViewAccountsPanel.Visible = false;
            AddAcountPanel.Visible = false;
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            AddAccountButtonSelected.Visible = true;
            AddAcountPanel.Visible = true;
        }

        private void ViewAccountsButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            ViewAccountsButtonSelected.Visible = true;
            ViewAccountsPanel.Visible = true;
            RefreshListview();
        }

        private void EditAccountsButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            EditAccountButtonSelected.Visible = true;
            AddAcountPanel.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            SettingsButtonSelected.Visible = true;
            AddAcountPanel.Visible = true;
        }

        private void LoadDatabaseButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            LoadDatabaseButtonSelected.Visible = true;
            AddAcountPanel.Visible = true;
        }

        private void SaveDatabaseButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            SaveDatabaseButtonSelected.Visible = true;
            AddAcountPanel.Visible = true;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            QuitButtonSelected.Visible = true;
            AddAcountPanel.Visible = true;
        }
        private void RefreshListview()
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
        }
    }
}
