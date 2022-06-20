using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number();
            myNumber.Amount = 52.26m;
            Console.WriteLine(myNumber.Amount);
            Console.ReadLine();
        }
    }
}
