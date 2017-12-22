using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowProxyEntrys
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

            string name;

            name = Convert.ToString(key.GetValue("ProxyOverride"));

            string[] names = name.Split(';');

            foreach (string a in names)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("");
            Console.Write("Bitte drücken Sie eine Taste um das Programm zu beenden...");
            Console.ReadKey();
        }
    }
}
