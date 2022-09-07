using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMethodSyntax
{
    class Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public List<int> Appraisal { get; set; }

        private static void DrawLine() => Console.Write(new string('-', Console.WindowWidth));
        public static void Display(List<Employees> employees)
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Full Name", "Salary", "Age");
            DrawLine();
            foreach (var employee in employees)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,-15}", employee.FirstName + " " + employee.LastName
                    , employee.Salary.ToString("C"), employee.Age.ToString());
            }
        }

        public static void DisplayWithApparisal(List<Employees> employees, string message)
        {
            if (message != string.Empty)
            {
                Console.WriteLine(message);
                DrawLine();
            }
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Full Name", "Salary", "Age", "Last Five Apparisals");
            DrawLine();

            foreach (var employee in employees)
            {
                Console.Write("{0,-15}{1,-15}{2,-15} /", employee.FirstName + " " + employee.LastName
                    , employee.Salary.ToString("C"), employee.Age.ToString());
                foreach (var app in employee.Appraisal)
                {
                    Console.Write(app + "/");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

    }
}
