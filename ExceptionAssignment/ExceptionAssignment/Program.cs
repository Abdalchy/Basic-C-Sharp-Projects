using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> nums = new List<int>() { 15, 20, 25, 30, 35, 40, 45 };
                string answer;
                int num;

                Console.WriteLine("Here is my list of numbers.");
                nums.ForEach(Console.WriteLine);
                Console.WriteLine("Please select a number to divide each number in the list by.");
                int chosenNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the integers in the list by: " + chosenNumber);

                for (int x = 0; x < nums.Count; x++)
                {
                    num = nums[x];
                    answer = Convert.ToString(num / chosenNumber);
                    Console.WriteLine(nums[x] + " divided by: " + chosenNumber + "equals: " + answer);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            Console.ReadLine();
        }
    }
}
