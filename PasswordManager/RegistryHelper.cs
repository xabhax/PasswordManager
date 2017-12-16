using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class RegistryHelper
    {
        public static string Datafile()
        {
            var tmp = Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Database", null).ToString();

            return tmp;
        }
    }
}
