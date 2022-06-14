using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Brazil", "Belgium", "France" };
            Console.WriteLine("Type a number between 0-2 to see Mens Fifa top rankings");
            int Mens = Convert.ToInt32(Console.ReadLine());

            if (Mens == 0)
            {
                Console.WriteLine(stringArray[Mens] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (Mens == 1)
            {
                Console.WriteLine(stringArray[Mens] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (Mens == 2)
            {
                Console.WriteLine(stringArray[Mens] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("That index does not exist.\n\nPress Enter");
                Console.ReadLine();
            }




            int[] intArray = { 10, 20, 40, 80, 160, 320 };

            Console.WriteLine("Choose an index number between 0-5");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine(intArray[num1] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (num1 == 1)
            {
                Console.WriteLine(intArray[num1] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (num1 == 2)
            {
                Console.WriteLine(intArray[num1] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (num1 == 3)
            {
                Console.WriteLine(intArray[num1] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (num1 == 4)
            {
                Console.WriteLine(intArray[num1] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (num1 == 5)
            {
                Console.WriteLine(intArray[num1] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("That index does not exist\n\nPress Enter");
                Console.ReadLine();
            }

            List<string> stringList = new List<string>();
            stringList.Add("Good_Morning");
            stringList.Add("Good_Afternoon");
            stringList.Add("Good_Evening");
            stringList.Add("Good_Night");

            Console.WriteLine("Select an index number between 0-3");
            int greeting = Convert.ToInt32(Console.ReadLine());

            if (greeting == 0)
            {
                Console.WriteLine(stringList[0] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (greeting == 1)
            {
                Console.WriteLine(stringList[1] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (greeting == 2)
            {
                Console.WriteLine(stringList[2] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else if (greeting == 3)
            {
                Console.WriteLine(stringList[3] + "\n\nPress Enter");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("That index number does not exist");
                Console.ReadLine();
            }
        }
    }
}
