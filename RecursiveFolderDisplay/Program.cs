using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFolderDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = string.Empty;
            path = "D:\\hi\\ex12";
            Console.WriteLine(path);
            DisplayFolders(path, 0);

        }

        public static void DisplayFolders(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                using (var reader = new StreamReader(Path.Combine(path, folder, "log.txt")))
                {
                    Console.WriteLine($"{new string(' ', indent)} {folder} : {reader.ReadLine()}");
                    DisplayFolders(folder, indent + 4);
                }
            }
        }
    }
}
