using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal partial class DictExEvent
    {
        public delegate void PrintDictEvent(Dictionary<int, string> myDict);

        public static void PrintDict(Dictionary<int, string> myDict)
        {
            foreach (KeyValuePair<int, string> item in myDict)
                Console.WriteLine($"{item.Key} : {item.Value}");
        }

        static void DictExEventMain()
        {
            PrintDictEvent handler = PrintDict;
            Dictionary<int, string> heyYo = new Dictionary<int, string>();
            heyYo.Add(1, "uno");
            heyYo.Add(2, "duos");
            heyYo.Add(3, "trees");

            handler(heyYo);
        }
    }
}
