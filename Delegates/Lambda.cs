using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Lambda
    {
        static void LambdaMain(string[] args)
        {
            Multiply MyMultiplyer = (n, m) => n * m;
            Multiplyv VoidMultiplyer = () => { Console.WriteLine("No Numbers"); };
            Console.WriteLine(MyMultiplyer(3, 5));
            CheckEven checkEven = i => { if (i % 2 == 0) return true; return false; };
            VoidMultiplyer();

            GenericListDel<int> ListAdderInt = (mylist, e) => { mylist.Add(e); };
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (var item in intList)
            //{
            //    Console.WriteLine(item);
            //}
            //ListAdderInt(intList, 4);
            //foreach (var item in intList)
            //{
            //    Console.WriteLine(item);
            //}
            ListEven<int> ListEvener = mylist =>
            {
                List<int> temp = new List<int>();
                for (int i = 0; i < mylist.Count; i++)
                {
                    if (checkEven(mylist[i]))
                    {
                        temp.Add(mylist[i]);
                    }
                }
                return temp;
            };

            List<int> evenlist = ListEvener(intList);
            foreach (var item in evenlist)
            {
                Console.WriteLine(item);
            }

        }
        public delegate int Multiply(int n, int m);
        public delegate void Multiplyv();
        public delegate void GenericListDel<T>(List<T> genList, T e);
        public delegate List<T> ListEven<T>(List<T> genList);
        public delegate bool CheckEven(int i);
    }
}
