using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole even number to divide by 2");
            int input = Convert.ToInt32(Console.ReadLine());

            var math = new Division();
            math.divide(input);
            Console.WriteLine("Press Enter");
            Console.ReadLine();



            int a, b;

            var math1 = new Division();
            math1.getValues(out a, out b);

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("Press Enter");
            Console.ReadLine();

            var math2 = new Division();

            int sum1 = math2.Add(1, 2);
            Console.WriteLine("sum of the two " + "integer value : " + sum1);

            int sum2 = math2.Add(1, 2, 3);
            Console.WriteLine("sum of the three " + "integer value : " + sum2);
            Console.WriteLine("Press Enter");
            Console.ReadLine();

            Console.WriteLine("Please enter a whole number to multiply by 2");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number multiplied by 2 is: " + Math.multiply(input2));
            Console.ReadLine();




        }
    }
}
