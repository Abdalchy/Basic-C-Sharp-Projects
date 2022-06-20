using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.id = 1;
            var employee2 = new Employee();
            employee2.id = 2;

            Console.WriteLine(employee == employee2);
            Console.ReadLine();

        }
    }
}
