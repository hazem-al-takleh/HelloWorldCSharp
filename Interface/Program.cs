using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animals ani = new Animals();
            //ani.Eat();
            //flow f = new flow();
            //f.Eat();
        }
    }
    class Animals : BirdInter
    {
        public void Eat()
        {
            Console.WriteLine("Buy");
        }
        public void Drink()
        {
            Console.WriteLine("Hi ");
        }
    }

    class flow : AnimalsInter
    {
        public void Eat()
        {
            Console.WriteLine("Bye");
        }
    }

    interface AnimalsInter
    {
        void Eat();
    }

    interface BirdInter : AnimalsInter
    {
        void Drink();

    }
}
