using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College \nStudent Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What program are you taking?");
            string yourProgram = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? please answer \"true\" or \"false\".");
            string assistRequire = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(assistRequire);

            Console.WriteLine("What course are you working on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("Please give a detailed description of your problem!");
            string yourQuestion = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to you shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}
