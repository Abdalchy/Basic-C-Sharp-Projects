using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //in the Main() method, create a list of at least 10 employees. 
            List<Employee> Employees = new List<Employee>() { };

            //at least two employees should have the first name "Joe".
            Employee employee1 = new Employee(1, "John", "Doe");
            Employees.Add(employee1);
            Employee employee2 = new Employee(2, "Jane", "Doe");
            Employees.Add(employee2);
            Employee employee3 = new Employee(3, "Joe", "Smith");
            Employees.Add(employee3);
            Employee employee4 = new Employee(4, "Glen", "James");
            Employees.Add(employee4);
            Employee employee5 = new Employee(5, "Sara", "Jones");
            Employees.Add(employee5);
            Employee employee6 = new Employee(6, "Bridgette", "Jone");
            Employees.Add(employee6);
            Employee employee7 = new Employee(7, "Mike", "Holmes");
            Employees.Add(employee7);
            Employee employee8 = new Employee(8, "Alex", "Alex");
            Employees.Add(employee8);
            Employee employee9 = new Employee(9, "Rob", "Rob");
            Employees.Add(employee9);
            Employee employee10 = new Employee(10, "Howard", "Duck");
            Employees.Add(employee10);

            List<Employee> Employees2 = new List<Employee>();
            foreach (Employee employee in Employees)
            {
                if (employee.firstName == "Joe")
                {
                    Employees2.Add(employee);
                }
            }
            foreach (Employee employee in Employees2)
            {
                Console.WriteLine(employee.firstName);
            }
            List<Employee> Employees3 = Employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee employee in Employees3)
            {
                Console.WriteLine(employee.firstName + " Using Lambda ");
            }
            List<Employee> greaterThan = Employees.Where(x => x.empID > 5).ToList();
            foreach (Employee employee in greaterThan)
            {
                Console.WriteLine("Here is a list of the employees with an ID > 5. :");
                Console.WriteLine("{0}, {1}, {2}", employee.empID, employee.firstName, employee.lastName);
            }
            Console.ReadLine();
        }
    }
}
