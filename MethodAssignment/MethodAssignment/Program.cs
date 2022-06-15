using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Operations Assignment!" +
                "\n\nEnter a number and we will divide by and multiply it by 3. Will will also add 3 to it." +
                "\n\nPlease choose a number:");
            int input = Convert.ToInt32(Console.ReadLine());

            var math = new Math_Operation();
            math.Divide(input);
            Console.WriteLine("\n Press Enter");
            Console.ReadLine();
            math.Multiplication(input);
            Console.WriteLine("\n Press Enter");
            Console.ReadLine();
            math.Adding(input);
            Console.ReadLine();





        }
    }
}