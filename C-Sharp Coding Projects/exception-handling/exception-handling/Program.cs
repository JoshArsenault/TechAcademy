using System;
using System.Collections.Generic;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //create list of integers
                List<int> numbers = new List<int>();
                numbers.Add(10);
                numbers.Add(20);
                numbers.Add(30);
                numbers.Add(40);
                numbers.Add(50);
                numbers.Add(60);
                numbers.Add(70);
                numbers.Add(80);
                numbers.Add(90);

                //ask user for number
                Console.WriteLine("Please enter a number to divide each number in the list by:");
                int userInput = Convert.ToInt32(Console.ReadLine());

                //iterate through list of integers, dividing each by user input
                foreach (int number in numbers)
                {
                    Console.WriteLine(number / userInput);
                }
                Console.ReadLine();
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please enter a valid number. (Not 0)");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid number");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
