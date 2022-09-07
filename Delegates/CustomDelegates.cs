using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal partial class CustomDelegate
    {
        static void CustomDelegateMain(string[] args)
        {
            CustomDel<int> dodo = new CustomDel<int>(RunTask<int>);

            dodo(5);

            CuDel<double> dodo1 = new CuDel<double>(TFun<double>);
            Console.WriteLine(dodo1(345.31d));
        }
        public delegate Type CuDel<Type>(Type obj);
        public static Type TFun<Type>(Type obj)
        {
            return obj;
        }
        public delegate void CustomDel<T>(T ob);

        public static void RunTask<T>(T ob)
        {
            Console.WriteLine($"Task {ob} is runniing");
        }
    }
}
