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
            string hash = RegistryHelper.GetKey("Password");
            var tmp = Crypto.Verify(MasterPassword.Text, hash);

            switch (tmp)
            {
                case true:
                    DialogResult = DialogResult.OK;
                    var tmpy = new LoginHelper(MasterPassword.Text);
                    break;

                default:
                    this.Close();
                    break;
            }
        }

        private void QuitButton(object sender, EventArgs e) => Close();

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LoginButton(null,null);
            }
        }
    }
}
