using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PasswordManager
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            DialogResult result;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check to see if registry settings are present
            if (!RegistryHelper.CheckFirstRun())
            {
                RegistryHelper.CreateSubKey("PasswordManager");
                Application.Run(new MainDialog());
                return;
            }
            else
            {
                // They are so lets check some credentials
                var loginForm = new Login();
                result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // login was successful
                    Application.Run(new MainDialog());
                    return;
                }
            }
        }
    }
}

