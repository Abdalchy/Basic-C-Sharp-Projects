using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Math_Operation
    {
        public void Divide(int divide)
        {
            int result = divide / 3;
            Console.WriteLine(divide + " divided by three is: " + result);
        }


        public void Multiplication(int multiply)
        {

            int result = multiply * 3;
            Console.WriteLine(multiply + " multiplied by three is: " + result);
        }


        public void Adding(int add)
        {

            int result = add + 3;
            Console.WriteLine(add + " plus three is: " + result);
        }

    }


}
