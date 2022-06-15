using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Methods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to proceed");

            int input = Convert.ToInt32(Console.ReadLine());


            var math = new Math_Operation();
            math.Passing_in_an_Integer(input);
            Console.WriteLine("\nPlease enter a number greater than five");
            decimal input1 = Convert.ToDecimal(Console.ReadLine());

            var math1 = new Math_Operation();
            math1.Passing_in_an_Decimal(input1);
            Console.WriteLine("\n Please enter a number to multiply by five");
            string input2 = Console.ReadLine();

            var math2 = new Math_Operation();
            math2.Passing_in_a_String(input2);
            Console.ReadLine();
        }
    }
}

