using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    public class Employee : Person
    {
        public int Id { get; set; }


        public void Quit()
        {
            Console.WriteLine("I quit");
        }
        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }


    }
}
