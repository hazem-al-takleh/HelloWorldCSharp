using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5ExerciseAssignmet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GermanSheapard max = new GermanSheapard();
            //max.Birth = DateTime.Now.AddYears(-6);
            //max.Name = "Max";
            //max.Gender = Gender.Male;
            //max.Origin = "Germany";
            //max.Weight = 32.54f;
            //max.Size = Size.Large;

            //max.ShowInfo();
            //max.Sit();
            //max.Hi();
            //max.Hi("Masha");
        }
    }
    /// <summary>
    /// Class Animal is a base class in the animals hierarchy
    /// </summary>
    class Animal
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Origin { get; set; }
        public Animal() { this.Name = "UNKOWN"; Birth = DateTime.MinValue; Origin = "UNKNOWN"; }

    }

    interface IDog
    {
        void Hi();
        void Stand();
        void Sit();
    }

    class GermanSheapard : Animal, IDog
    {
        public Gender Gender { get; set; }
        public float Weight { get; set; }
        bool SecurityGuard { get; set; }
        string Training { get; set; }
        public Size Size { get; set; }

        public void Hi()
        {
            Console.WriteLine($"Dog Hi");
            Console.WriteLine("frkhgrjwgj");
        }
        public void Hi(string dogName)
        {
            this.Name = dogName;
            Console.WriteLine($"{dogName} Hi");
        }
        public void Stand()
        {
            Console.WriteLine($"{this.Name} stand");
        }
        public void Sit()
        {
            Console.WriteLine($"{this.Name} sit");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"The dog name is {this.Name} from {this.Origin}, was born on {this.Birth.ToShortDateString()}\n" +
                $"{this.Name} is a {this.Gender} and Weights {this.Weight} and its Size is {this.Size}");
        }

    }
    enum Size { Small, Medium, Large }
    enum Gender { Male, Female }

}
