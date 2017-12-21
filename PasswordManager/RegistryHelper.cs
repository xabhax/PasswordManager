using Microsoft.Win32;

namespace PasswordManager
{
    class RegistryHelper
    {
        /// <summary>
        /// Returns database location
        /// </summary>
        public static string Datafile
        {
            get
            {
                return Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Database", null).ToString();
            }   
        }

        /// <summary>
        /// Checks for a registry value to determine if this is the first time running
        /// </summary>
        /// <returns>true if the value exists, false if it doesnt</returns>
        public static bool CheckFirstRun()
        {
            return (Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", "Password", null).ToString() == null) ? false : true;
        }

        /// <summary>
        /// Gets value of the registry key provided
        /// </summary>
        /// <param name="RegKey"></param>
        /// <returns>returns string with registry value</returns>
        public static string GetKey(string RegKey)
        {
            return  Registry.GetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", RegKey, null).ToString();
        }

        /// <summary>
        /// Creates a registry key
        /// </summary>
        /// <param name="KeyName">Name of key to be created</param>
        public static void CreateSubKey(string KeyName)
        {
            Registry.CurrentUser.CreateSubKey(KeyName);
        }

        /// <summary>
        /// Sets the value of a registry
        /// </summary>
        /// <param name="KeyName">Name of key to be added</param>
        /// <param name="Value">Value to add to that key</param>
        public static void SetKeyValue(string KeyName, string Value)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PasswordManager", KeyName, Value);
        }
    }
}
