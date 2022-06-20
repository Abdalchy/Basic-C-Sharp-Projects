using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string num = string.Format(Console.ReadLine());

            File.WriteAllText(@"C:\Logs\log.txt", num);

            string display = File.ReadAllText(@"C:\Logs\log.txt");
            Console.WriteLine(display);

            Console.ReadLine();
        }
    }
}
