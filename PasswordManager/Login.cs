using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton(object sender, EventArgs e)
        {
            string hash = Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Password", null).ToString();
            var tmp = Crypto.Verify(MasterPassword.Text, hash);

            switch (tmp)
            {
                case true:
                    DialogResult = DialogResult.OK;
                    break;

                default:
                    this.Close();
                    break;
            }
        }

        private void QuitButton(object sender, EventArgs e) => Close();
    }
}
