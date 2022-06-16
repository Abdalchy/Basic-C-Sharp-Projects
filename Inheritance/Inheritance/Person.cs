using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public void SayName()
        {
            Console.WriteLine("Employee Id: " + Id + " Name: " + FirstName + " " + LastName);
        }
    }
}

