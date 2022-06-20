using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    public class Message
    {
        public static void myMethod()
        {
            Console.WriteLine("Please enter your age:");
            int currentDate = DateTime.Now.Year;
            int age = Convert.ToInt32(Console.ReadLine());
            int DOB = currentDate - age;
            if (age <= 0)
            {
                Console.WriteLine("Please enter a number greater than 0");
                Message.myMethod();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You were born in " + DOB);
                Console.ReadLine();
            }
        }
    }
}
