using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WEBPtoJPG
{
    internal class Utils
    {
        public static bool SetFolderContextMenu()
        {
            try
            {
                RegistryKey k = Registry.ClassesRoot.CreateSubKey(@".webp\Shell\Convert...\command");
                k.SetValue("", $"\"{System.Reflection.Assembly.GetExecutingAssembly().Location}\" \"%1\"");
                k.Close();
                k = Registry.ClassesRoot.CreateSubKey(@".webp\Shell\Convert auto\command");
                k.SetValue("", $"\"{System.Reflection.Assembly.GetExecutingAssembly().Location}\" \"%1\" -auto");
                k.Close();
                k = Registry.ClassesRoot.CreateSubKey(@".webp\Shell\Convert auto all in folder\command");
                k.SetValue("", $"\"{System.Reflection.Assembly.GetExecutingAssembly().Location}\" \"%1\" -autoall");
                k.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
