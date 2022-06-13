using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players on a professional soccer team?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isguessed = number == 11;

            do
            {
                switch (number)
                {
                    case 12:
                        Console.WriteLine("You guessed 12. Try again.");
                        Console.WriteLine("How many players on a professional soccer team?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9. Try again.");
                        Console.WriteLine("How many players on a professional soccer team?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10. Try again.");
                        Console.WriteLine("How many players on a professional soccer team?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("You guessed 11. Correct, there are 11 players!");
                        isguessed = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect.");
                        Console.WriteLine("Try again, how many players on a professional soccer team?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isguessed);

            Console.Read();

        }
    }
}
