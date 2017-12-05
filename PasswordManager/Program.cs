using System;
using System.Windows.Forms;
using Microsoft.Win32;
using PasswordManager.Forms;

namespace PasswordManager
{
    public class Program
    {
        public static Main MainForm { get; private set; }

        [STAThread]
        public static void Main()
        {
            DialogResult result;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm = new Main());
        }
    }
}

