using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main()
        {
            Employee<dynamic> employee1 = new Employee<dynamic>();
            employee1.things = new List<dynamic>() { "My", "name", "is", "John", "Doe" };

            Employee<dynamic> employee2 = new Employee<dynamic>();
            employee2.things = new List<dynamic>() { 2, 4, 6, 8, 10 };

            var Staff = new List<List<dynamic>>();
            Staff.Add(employee1.things);
            Staff.Add(employee2.things);

            foreach (List<dynamic> emp in Staff)
            {
                foreach (dynamic x in emp)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
