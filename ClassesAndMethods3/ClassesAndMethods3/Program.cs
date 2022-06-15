using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Methods_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers one at a time.");

            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());

            var math = new Math_Operation();
            math.Passing_In_Two_Numbers(firstInput: input1, secondInput: input2);
            Console.ReadLine();
        }
    }
}
