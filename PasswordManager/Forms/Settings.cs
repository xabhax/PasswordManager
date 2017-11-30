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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void SaveDataFile(object sender, EventArgs e)
        {
            DialogResult result;
            SaveFileDialog DatafileLocation = new SaveFileDialog
            {
                Filter = "PasswordManager Database (*.pmd)|*.pmd",
                FileName = "database",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                RestoreDirectory = true
            };

            result = DatafileLocation.ShowDialog();
            if (result == DialogResult.OK)
            {
                Datafile.Text = DatafileLocation.FileName;
            }
        }
        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsUsername.Text.Length != 0 && settingsPassword.Text.Length != 0 && Datafile.Text.Length != 0)
            {
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Username", Crypto.EncryptText(settingsUsername.Text));
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Password", Crypto.EncryptText(settingsPassword.Text));
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Datafile", Datafile.Text.ToString());
            }
            else
            {
                MessageBox.Show("You must complete all fields before applying changes", "Error");
            }
        }
    }
}
