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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Login was not successfull
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Login was succesfull
            if (Crypto.CheckLoginCredentials(UsernameInput.Text, PasswordInput.Text) == true)
            {
                DialogResult = DialogResult.OK;
            }

            // Wrong password, close program
            else
            {
                this.Close();
            }

        }
    }
}
