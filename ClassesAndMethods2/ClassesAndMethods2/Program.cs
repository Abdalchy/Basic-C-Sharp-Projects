using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello enter two numbers one at a time. You don't need to enter anything for the second number.");

            int input1 = Convert.ToInt32(Console.ReadLine());
            int result;
            var math = new Math_Operation();
            try
            {

                int input2 = Convert.ToInt32(Console.ReadLine());
                result = math.Passing_In_Two_Integers(input1, input2);
            }

            catch
            {
                result = math.Passing_In_Two_Integers(input1);
            }

            Console.WriteLine("Your entry plus 5 is: " + result);




            Console.ReadLine();

        }
    }
}