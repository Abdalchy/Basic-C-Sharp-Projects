using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 1;
            employee2.FirstName = "Sample";
            employee2.LastName = "Student";
            employee2.Id = 1;
            employee3.FirstName = "Bob";
            employee3.LastName = "Starter";
            employee3.Id = 3;

            if (employee.Id == employee2.Id)
            {
                Console.WriteLine("Duplicate Employee ID's");
                Console.ReadLine();
            }

            else
            {
                employee.SayName();
                employee2.SayName();
                Console.ReadLine();
            }
        }
    }
}
