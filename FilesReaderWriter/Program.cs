using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReaderWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = "C:\\Users\\ASUS\\source\\hi\\hello";
            string fileName = "test.txt";
            string filePath = Path.Combine(dir, fileName);

            System.IO.StreamReader sr = new System.IO.StreamReader(filePath);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
}
