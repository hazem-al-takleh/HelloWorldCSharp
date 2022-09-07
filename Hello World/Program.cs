using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Student
    {
        int id;
        string name;
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Student()
        {
            id = 0;
            name = "";
            age = 0;
        }

        public Student(int id, String name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }


    }

    internal class Program
    {


        static void Main(string[] args)
        {
            Student student1 = new Student(id:15, age:32, name:"Hazem");
            Console.WriteLine(student1.Age);

        }

        //string firstEmployee, secondEmployee;

        ////firstEmployee = "David Smith";
        ////secondEmployee = "Sophia Watson";

        ////Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee} \n{secondEmployee}\n\n");

        //ChangeNames(out firstEmployee, out secondEmployee);

        //Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee} \n{secondEmployee}\n\n");

        static void ChangeNames(out string firstEmp, out string secEmp)
        {
            firstEmp = "Olivia Aaron";
            secEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method\n----------\n{firstEmp} \n{secEmp}\n\n");
        }

        public enum StudentTypes
        {
            publicStudent = 0,
            privateStudent = 5
        }

        static void DoneMessage()
        {
            Console.WriteLine("Fin");
            Console.WriteLine("At " + DateTime.Now.ToString());

        }

        static int AddResults(int a, int b)
        {
            return a + b;
        }
        static double AddResults(double a, double b)
        {
            return a + b;
        }
        static void InfinateLoop()
        {
            for (; ; )
            {
                Console.WriteLine();
            }
        }

        static List<int> GetIndexes(String str)
        {
            List<int> listIndexes = new List<int>();
            return listIndexes;
        }

        static String PrintAge(int userAge, bool userAgeReadState)
        {
            if (!userAgeReadState)
                return "only integer positive inputs (valid ages) are allowed";
            else
            {
                DateTime csharpDateOfBirth = new DateTime(2002, 1, 1);
                TimeSpan csharpAge = DateTime.Now - csharpDateOfBirth;
                return $"{userAge} good, As for me I was born in 2002 which makes me {Math.Round(csharpAge.TotalDays / 356)} years old";
            }
        }

        static void ConversationTask()
        {
            Console.WriteLine("What's your name ?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello there {userName} nice to meet you, I'm C#. How old are you?");
            int userAge;
            bool userAgeReadState = int.TryParse(Console.ReadLine(), out userAge);
            Console.WriteLine(PrintAge(userAge, userAgeReadState));

        }


        static void TaskDate()
        {
            DateTime myPlayDate = new DateTime(2017, 09, 30, 09, 09, 59);
            Console.WriteLine("{0:dd-MM-yyyy hh:mm:ss}", myPlayDate);
            Console.WriteLine("{0:dddd} of month {0:MMMM} year {0:yyyy}", myPlayDate);
            Console.WriteLine("Day {0:dddd}\nMonth {0:MMMM}\nYear {0:yyyy}", myPlayDate);
            Console.WriteLine("{0:'Day' dddd\n'Month' MMMM\n'Year' yyyy}", myPlayDate);
        }

        static TimeSpan GetTimestamp(DateTime value)
        {
            DateTime date1 = new DateTime(1970, 1, 1);

            return value - date1;
        }

    }
}
