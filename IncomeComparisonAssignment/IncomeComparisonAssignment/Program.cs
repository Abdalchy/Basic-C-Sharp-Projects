using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonumous Income Comparison Program \nPress Enter to Continue");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("\nHourly Rate?");
            string hrlyRate1 = Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("\nHours worked per week?");
            string workHours1 = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("\nHourly Rate?");
            string hrlyRate2 = Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("\nHours worked per week?");
            string workHours2 = Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1:");
            double num1 = Convert.ToDouble(hrlyRate1);
            double num2 = Convert.ToDouble(workHours1);
            double product1 = num1 * num2 * 52;
            Console.WriteLine(product1 + "\nPlease Press Enter");
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2:");
            double num3 = Convert.ToDouble(hrlyRate2);
            double num4 = Convert.ToDouble(workHours2);
            double product2 = num3 * num4 * 52;
            Console.WriteLine(product2 + "\nPlease Press Enter");
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2");
            bool trueOrFalse = product1 > product2;
            Console.WriteLine(trueOrFalse.ToString() + "\n\nPlease Press Enter to Close Window");
            Console.ReadLine();

        }
    }
}
