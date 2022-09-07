using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MWNS.GOT;
using MWNS;

namespace OOPEx
{

    internal class exCars
    {
        private static void Main(string[] args)
        {
            //Car myCar = new Car();
            //myCar.DisplayInfo();
            //Car myMer = new Mercedes();
            //myMer.DisplayInfo();

            //int jerng = addRes();
            //Console.WriteLine(jerng);


            System.Console.WriteLine();
            MWNS.Animal animal = new MWNS.Animal();
            animal.SayHi();
            MWNS.GOT.HouseStark.sayQuote();
            HouseStark.sayQuote();


        }

        public static int addRes()
        {
            return 5 + 4;
        }
    }

    class Car
    {
        private decimal price = 10000.0m;
        public string color = "Black";
        protected int maxSpeed = 300;

        

        public decimal Price { get { return price; } set { price = value; } }
        //public int MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }

        public void DisplayInfo()
        {
            string msg = "";
            msg += string.Format($"the price is {price}\n");
            msg += string.Format($"the color is {color}\n");
            msg += string.Format($"the max speed is {maxSpeed}");
            Console.WriteLine(msg);
        }
    }

    class Mercedes : Car
    {
        public Mercedes()
        {


            this.Price = 15000.0m;
            this.color = "Blue";
            this.maxSpeed = 280;
        }

    }
}

namespace MWNS
{
    class Animal
    {
        public string animalColor = "";

        public void SayHi()
        {
            Console.WriteLine("Hi from the custom namespace");
        }
    }

    class Trainers
    {
    }

    namespace GOT
    {
        class HouseStark
        {
            public static void sayQuote()
            {
                Console.WriteLine("The north remembers");
            }
        }
    }
}
