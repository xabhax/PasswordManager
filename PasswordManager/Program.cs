using System;
using System.Windows.Forms;
using Microsoft.Win32;
using PasswordManager.Forms;

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
            Application.Run(new TestMain());
        }
    }
}

