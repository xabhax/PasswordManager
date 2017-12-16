using Microsoft.Win32;
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

            if (tmp == true)
            {
                MessageBox.Show("Right");
            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }

        private void QuitButton(object sender, EventArgs e)
        {

        }
    }
}
