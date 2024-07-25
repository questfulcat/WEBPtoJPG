using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WEBPtoJPG
{
    internal class Utils
    {
        static void addKey(string key, string value)
        {
            RegistryKey k = Registry.ClassesRoot.CreateSubKey(key);
            k.SetValue("", value);
            k.Close();
        }

        public static bool SetWEBPExtensionContextMenu()
        {
            try
            {
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                addKey(@".webp\Shell\Convert...\command", $"\"{path}\" \"%1\"");
                addKey(@".webp\Shell\Convert auto\command", $"\"{path}\" \"%1\" -auto");
                addKey(@".webp\Shell\Convert auto all in folder\command", $"\"{path}\" \"%1\" -autoall");

                addKey(@"SystemFileAssociations\.webp\Shell\Convert...\command", $"\"{path}\" \"%1\"");
                addKey(@"SystemFileAssociations\.webp\Shell\Convert auto\command", $"\"{path}\" \"%1\" -auto");
                addKey(@"SystemFileAssociations\.webp\Shell\Convert auto all in folder\command", $"\"{path}\" \"%1\" -autoall");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\r\nTry to run app as administrator");
                return false;
            }
        }
    }
}
