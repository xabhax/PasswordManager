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
        public static bool CheckFirstRun()
        {
            var tmp = Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Password", null).ToString();

            if (tmp == null) return false;
            else return true;
        }
        public static string GetKey(string RegKey)
        {
            var tmp = Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", RegKey, null).ToString();

            return tmp;
        }
        public static void CreateSubKey(string KeyName)
        {
            Registry.CurrentUser.CreateSubKey(KeyName);
        }
        public static void SetKeyValue(string KeyName, string Value)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", KeyName, Value);
        }
    }
}
