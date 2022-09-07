using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> multiplyer = (a, b) => a * b;
            Func<int, bool> EvenChecker = a => a % 2 == 0;

            Func<int, List<int>, bool> ListEvener = (a, myList) =>
            {
                if (!EvenChecker(a))
                    return myList.Remove(a);
                else
                    return false;
            };

            Action<List<int>> IntListPrinter = myList =>
            {
                foreach (int item in myList)
                {
                    Console.WriteLine(item);
                }
            };

            Console.WriteLine(multiplyer(1, 2));
            Console.WriteLine(EvenChecker(3));
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IntListPrinter(ints);
            Console.WriteLine();

            var e = ints.GetEnumerator();
            while (e.MoveNext())
            {
                if (ListEvener(e.Current, ints))
                {
                    e = ints.GetEnumerator();
                }
            }
            IntListPrinter(ints);

        }
    }
}

