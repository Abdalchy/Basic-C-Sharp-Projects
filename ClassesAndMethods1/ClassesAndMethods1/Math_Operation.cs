using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Methods_1
{
    public class Math_Operation
    {
        public void Passing_in_an_Integer(int add)
        {
            int result = add + 5;
            Console.WriteLine(add + " plus five is: " + result);
        }

        public void Passing_in_an_Decimal(decimal subtract)
        {
            decimal result = subtract - 5;
            Console.WriteLine(subtract + " minus five is: " + Convert.ToInt32(result));
        }

        public void Passing_in_a_String(string multiply)
        {
            int result = Convert.ToInt32(multiply) * 5;
            Console.WriteLine(multiply + " times five is: " + result);
        }
    }
}
