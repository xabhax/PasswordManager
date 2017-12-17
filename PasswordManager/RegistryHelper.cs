using Microsoft.Win32;
using System;

namespace PasswordManager
{
    class RegistryHelper
    {
        public static string Datafile
        {
            get
            {
                var tmp = Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Database", null).ToString();

                return tmp;
            }
        }
    }
}
