using System;
using System.Windows.Forms;
using Microsoft.Win32;
using PasswordManager.Forms;

namespace PasswordManager
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            DialogResult result;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check to see if we have been run before
            if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Username", null) == null)
            {
                Registry.CurrentUser.CreateSubKey("PasswordManager");
                Application.Run(new Settings());
            }

            else
            {
                // Setup to show login form
                var loginForm = new Login();
                result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Login was successful
                    Application.Run(new Main());
                }
            }
        }
    }
}
