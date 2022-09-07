using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZeroEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DivZero();
        }

        //class UserInput
        //{
        //    decimal userInputDecimal;
        //    string exceptionMessage;

        //    public decimal UserInputDecimal
        //    {
        //        get { return userInputDecimal; }
        //        set { userInputDecimal = value; }
        //    }
        //    public string ExceptionMessage
        //    {
        //        get { return exceptionMessage; }
        //        set { exceptionMessage = value; }
        //    }
        //}

        //just cool and easy
        class Counter
        {
            int c = 0;
            public void Thresh(int threshold)
            {
                this.c++;
                if (c >= threshold)
                {
                    throw new Exception("\n\nSTAAAAAAAAAAAAAHP\n\n");
                }
            }
        }
        static decimal TakeUserInput(string command)
        {
            Counter counter = new Counter();
            startAgain:
            try
            {
                Console.Write(command);
                decimal userInputInDecinal = Convert.ToDecimal(Console.ReadLine());
                return userInputInDecinal;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                counter.Thresh(2);
                goto startAgain;
            }
        }

        //the wrong overengineering way to do it
        //static UserInput TakeUserInputi(string command)
        //{
        //    UserInput userInputExeption = new UserInput();
        //    try
        //    {
        //        Console.WriteLine(command);
        //        userInputExeption.UserInputDecimal = Convert.ToDecimal(Console.ReadLine());

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        throw e;
        //    }
        //    return userInputExeption;
        //}
        //
        //
        //res = a.UserInputDecimal / b.UserInputDecimal;

        static void DivZero()
        {
            decimal a;
            decimal b;
            try
            {
                a = TakeUserInput("Enter First Number: ");
                b = TakeUserInput("Enter Secon Number: ");
            }
            catch (Exception e) { Console.WriteLine(e.Message); return; }

            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"The result is {a / b}");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }


    }


}
