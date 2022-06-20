using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Message.myMethod();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your System Administrator");
                Console.ReadLine();
                return;
            }
        }
    }
}
