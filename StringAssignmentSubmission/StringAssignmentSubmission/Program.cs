using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Abdal!";
            string greeting = "Hello! ";
            string middle = "my name is ";

            string str = greeting + middle + name;

            string state = "This was all set to upper case.";
            state = state.ToUpper();


            StringBuilder sb = new StringBuilder();

            sb.Append("\t Hello! my name is Abdal. ");
            sb.Append("I am a student at the Academy of Learning. ");
            sb.Append("I am studying Software Web Development. ");
            sb.Append("\n I am an avid football fan. ");
            sb.Append("IN my spare time, you can usually find me watching Fifa. ");

            Console.WriteLine(str);
            Console.WriteLine(state);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
