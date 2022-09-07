using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Multicast
    {
        static void MulticastMain(string[] args)
        {
            SayHi handlerHi = null;
            handlerHi += new SayHi(HiArabic);
            handlerHi += new SayHi(HiEnglish);
            handlerHi += new SayHi(HiFrench);

            handlerHi.Invoke();
        }
        public delegate void SayHi();
        public static void HiEnglish()
        {
            Console.WriteLine("hi");
        }

        public static void HiFrench()
        {
            Console.WriteLine("bonjours");
        }

        public static void HiArabic()
        {
            Console.WriteLine("Marhaba");
        }

        public delegate void Arithmatics(int a, int b);
        static void MainEx18(string[] args)
        {

            Arithmatics handler = null;
            handler += (a, b) => Console.WriteLine(a + b); ;
            handler += (a, b) => Console.WriteLine(a - b); ;
            handler += (a, b) => Console.WriteLine(a * b); ;
            handler += (a, b) => Console.WriteLine((double)a / b); ;
            handler += (a, b) => Console.WriteLine(a % b); ;

            handler(1, 2);

        }
    }

}
