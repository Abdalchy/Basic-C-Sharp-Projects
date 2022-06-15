using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    public class Division
    {
        public void divide(int input)
        {
            int result = input / 2;
            Console.WriteLine(input + "  divided by two equals: " + result);

        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter a number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }

    public static class Math
    {

        public static int multiply(int input2)
        {
            int result2 = input2 * 2;
            return result2;

        }
    }


}

