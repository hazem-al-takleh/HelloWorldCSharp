using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace Collectoins
{
    class Program
    {

        static void Main(string[] args)
        {
            var list = GetList(1_000_000_000);
            foreach (var item in list)
            {
                if (item > 20)
                    break;
                Console.WriteLine(item);
            }
        }


        static IEnumerable<int> GetList(int count)
        {
            List<int> list = new List<int>();
            var test = list.GetEnumerator();
            for (int i = 0; i < count; i++)
                yield return i;
        }

        public static T[] ArrayAssigner<T>(params T[] array)
        {
            return array;
        }
    }
}
