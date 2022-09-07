using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Anon
    {
        static void AnonMain(string[] args)
        {
            CustomDelAnon anonHan = delegate { Console.WriteLine("Hello from Anon"); };
            CustomDelAnonParam anonHanning = delegate (int n) { Console.WriteLine("Hello from anon with param:" + n); };

            anonHan();
            anonHanning(5);
        }
        public delegate void CustomDelAnon();
        public delegate void CustomDelAnonParam(int number);
    }
}
