using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace PasswordManager
{
    public partial class MainDialog : Form
    {
        string DataFile = RegistryHelper.Datafile;
        List<Entry> Entries = new List<Entry>();

        public MainDialog()
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
            SettingsPanel.Visible = false;
        }

        #region Button Click Events
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
            //EditAccountsPanel.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            SettingsButtonSelected.Visible = true;
            SettingsPanel.Visible = true;
        }

        private void LoadDatabaseButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            LoadDatabaseButtonSelected.Visible = true;
            //LoadDatabasePanel.Visible = true;
        }

        private void SaveDatabaseButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            SaveDatabaseButtonSelected.Visible = true;
            //SaveDatabasePanel.Visible = true;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            ClearAllMainPanels();
            ClearAllButtonSelectPanels();
            QuitButtonSelected.Visible = true;
            
        }
        #endregion

        #region ViewAccounts Panel
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
        #endregion

        #region AddAccounts Panel
        private void GeneratePassword_Click(object sender, EventArgs e)
        {
            string GeneratedPassword = Guid.NewGuid().ToString("N").ToLower()
                                       .Replace("1", "").Replace("o", "").Replace("0", "")
                                       .Replace("m", "!").Substring(0, 25);

            PasswordInput.Text = GeneratedPassword;
            Password2Input.Text = GeneratedPassword;
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            Entries.Add(new Entry(UsernameInput.Text, PasswordInput.Text, WebsiteInput.Text));
            Storage.SerializeEntries(Entries, DataFile);
            MessageBox.Show("Account Added", "Password Manager");
            AddAcountPanel.Visible = false;
            ViewAccountsPanel.Visible = true;
            RefreshListview();
        }
        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            string str = PasswordStregth.Instance.GetPasswordStrength(UsernameInput.Text, PasswordInput.Text);

            switch (str)
            {
                case "Strong":
                    PasswordScore.BackColor = Color.White;
                    PasswordScore.BackColor = Color.Green;
                    PasswordScore.Text = str;
                    break;

                case "Good":
                    PasswordScore.BackColor = Color.White;
                    PasswordScore.BackColor = Color.Green;
                    PasswordScore.Text = str;
                    break;

                case "Weak":
                    PasswordScore.BackColor = Color.White;
                    PasswordScore.BackColor = Color.Yellow;
                    PasswordScore.Text = str;
                    break;

                case "Short":
                    PasswordScore.BackColor = Color.White;
                    PasswordScore.BackColor = Color.Red;
                    PasswordScore.Text = str;
                    break;
            }
        }
        #endregion

        #region Settings Panel
        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            var tmp = Crypto.Hash(MasterPassword.Text);

            RegistryHelper.CreateSubKey("PasswordManager");
            RegistryHelper.SetKeyValue("Password", tmp);
            RegistryHelper.SetKeyValue("Database", DatabaseLocation.Text);

            File.Create(DatabaseLocation.Text);
        }
        private void DatabaseLocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog datafiledlg = new SaveFileDialog
            {
                Filter = "Password Manager Database (*.pmd)|*.pmd",
                FileName = "Database.pmd",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                RestoreDirectory = true
            };
            DialogResult result;

            result = datafiledlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                DatabaseLocation.Text = datafiledlg.FileName;
            }
        }
        #endregion
    }
}
