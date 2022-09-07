using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    class Program
    {
        //private static void Main(string[] args)
        //{
        //    Shapes[] shapes = new Shapes[4];
        //    shapes[0] = new Shapes();
        //    shapes[1] = new Circles();
        //    shapes[2] = new Lines();
        //    shapes[3] = new Triangle();

        //    foreach (var shape in shapes)
        //    {
        //        shape.Draw();
        //    }
        //}
    }

    class Shapes
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a simple shape");
        }
    }

    class Circles : Shapes
    {
        public new void Draw()
        {
            Console.WriteLine("I am circle");
        }
    }

    class Lines : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am line");
        }
    }

    class Triangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am triangle");
        }
    }


    //internal class Program
    //{



    //    static void Main(string[] args)
    //    {
    //        //Animal nono = new Animal();
    //        //Dog dodo = new Dog();

    //        TwoWheeledVehicle myMotorCycle = new TwoWheeledVehicle(1.0f);
    //        Console.WriteLine(myMotorCycle.Wheels);
    //        myMotorCycle.ThrottleWheel();
    //        Console.WriteLine(myMotorCycle.Wheels);


    //    }
    //}
    class IntHazem
    {
        public int intValue;

        public int Value
        {
            get { return intValue; }
            set { intValue = value; }

        }
    }
    class Vehicle
    {

    }

    class WheeledVehicle : Vehicle
    {
        protected String Color;
        protected float price;
        protected float wheelsDiameter;

        protected void ChangeColor(String Color)
        {
            this.Color = Color;
        }

        protected void ChangeWheels(float Wheels)
        {
            this.wheelsDiameter = Wheels;
        }
    }

    class FourWheeledVehicle : WheeledVehicle
    {
        public void Drift()
        {
            this.wheelsDiameter -= 0.01f;
        }
    }

    class TwoWheeledVehicle : WheeledVehicle
    {
        public float Wheels
        {
            get { return this.wheelsDiameter; }
        }

        public TwoWheeledVehicle(float diam)
        {
            this.wheelsDiameter = diam;
        }

        public void ThrottleWheel()
        {
            this.wheelsDiameter -= 0.001f;
        }

    }

    class Animal
    {
        String animalName;
        DateTime animalDateOfBirth;

        protected void ConsumeEnergy() { }
        internal void DisposeShit() { }

    }

    class Dog : Animal
    {
        String Bread;

        Dog dodo = new Dog();

        void RunPark() { }
    }
}