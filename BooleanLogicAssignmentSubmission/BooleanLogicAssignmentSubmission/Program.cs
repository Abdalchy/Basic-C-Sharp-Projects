using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval");
            Console.WriteLine("\nPress enter to complete approval questions");
            Console.ReadLine();

            Console.WriteLine("\nWhat is your age?");
            string num1 = Console.ReadLine();
            int age = Convert.ToInt32(num1);

            Console.WriteLine("\nHave you aver had a DUI? \nPlease answer true or false");
            string textBoxAnswer = Console.ReadLine();
            bool DUI = Convert.ToBoolean(textBoxAnswer);

            Console.WriteLine("\nHow many speeding tickets do you have?");
            string num2 = Console.ReadLine();
            int spdTickets = Convert.ToInt32(num2);

            Console.WriteLine("\nQualified?");
            Console.WriteLine(age >= 16 && DUI == false && spdTickets <= 3);

            Console.ReadLine();

        }
    }
}
