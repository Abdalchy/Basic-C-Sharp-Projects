using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1
            string[] fifaArray = new string[10] { "Braizl ", "Belgium ", "France ", "Argentina ", "England ", "Itlay ", "Spain ", "Portugal ", "Mexica ", "Netherlans " };

            Console.WriteLine("What would your FIFA team mascot be : ");
            string x = Console.ReadLine();
            int y;

            for(y = 0; y < fifaArray.Length; y++)
            {
                fifaArray.SetValue(fifaArray.GetValue(y) + x, y);
                Console.WriteLine(fifaArray.GetValue(y));
            }
            Console.ReadLine();

            //PART 2
            //while (2==2)
            //{
            //Console.WriteLine("Infinite Loop!!!!!!!!!!! :D");
            //}

            int myNum = 15;
            while (myNum != 4)
            {
                myNum--;
                Console.WriteLine(myNum);
            }
            Console.ReadLine();

            //PART 3
            int addition = 6;
            while (addition < 30)
            {
                addition = addition + 6;
                Console.WriteLine(addition);
            }
            Console.ReadLine();

            int orEqual = 4;
            while (orEqual <= 40)
            {
                orEqual = orEqual + 4;
                Console.WriteLine(orEqual);
            }
            Console.ReadLine();

            //PART 4
            //List<string> holidays = new List<string>() { "Halloween", "Thanksgiving", "Christmas",  "Valentines day", "Victoria Day", "Canada Day" };
            //bool found = false;
            //int i; 

            //Console.WriteLine("Is your favorite holiday on the list? Type it here to see: ");
            //string inputHoliday = Console.ReadLine().ToLower();

            //while (!holidays.Contains(inputHoliday))
            //{
            //    Console.WriteLine("Sorry, it did not make the list.");
            //    Console.Write("Is your favorite holiday on the list? Type it here to see: ");
            //    inputHoliday = Console.ReadLine().ToLower();
            //}

            //foreach (string holiday in holidays)
            //{
            //    if (holiday == inputHoliday)
            //    {
            //        Console.WriteLine($"{holiday} is on my list!");
            //        break;
            //    }
            //}

            //for (i = 0; i < holidays.Count; i++)
            //{
            //    if (holidays[i].Contains(inputHoliday))
            //    {
            //        Console.WriteLine("{0}: {1}", i, holidays[i]);
            //        found = true;
            //    }
            //}
            //Console.ReadLine();

            //PART 5
            //create a list of strings that has at least two identical strings in the list. 
            //List<string> videoGames = new List<string>() { "fortnite", "sims", "minecraft", "mortal kombat", "minecraft" };

            //ask the user to select text to search for in the list.
            //Console.WriteLine("Enter a video game to see if it's on my list and how many times it's on there: ");
            //string userGame = Console.ReadLine().ToLower();

            //add code to the loop that tells a user if they put in text that isn’t in the list.
            //while (!videoGames.Contains(userGame))
            //{
            //    Console.WriteLine($"Sorry but the game {userGame}, is not on my list.");
            //    userGame = Console.ReadLine().ToLower();
            //}

            //create a loop that iterates through the list and displays 
            //the indices of the list that contain matching text on the screen.
            //for (int i = 0; i < videoGames.Count; i++)
            //{
            //    if (videoGames[i] == userGame)
            //    {
            //        Console.WriteLine($"The game {userGame}, is on my list at the index {i}");
            //    }
            //}
            //Console.ReadLine();


            //PART 6
            List<string> seasons = new List<string>() { "fall", "winter", "autumn", "spring", "summer", "fall", "autumn" };
            List<string> doubles = new List<string>();

            foreach (string season in seasons)
            {
                Console.WriteLine($"{season}");

                foreach (string d in doubles)
                {
                    if (d == season)
                    {
                        Console.Write($" {season} Already appeared. ");
                    }
                }
                doubles.Add(season);
            }
            Console.ReadLine();
        }
    }
}
