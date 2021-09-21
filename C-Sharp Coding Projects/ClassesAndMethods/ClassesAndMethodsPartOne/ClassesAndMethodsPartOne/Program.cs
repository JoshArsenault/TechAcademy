using System;

namespace ClassesAndMethodsPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //========================================================
            // Part One                                             //
            //========================================================

            //get numbers from user
            Console.WriteLine("Please enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //instanciate addNumbers
            SimpleMath simplemath = new SimpleMath();

            //display answer to user
            Console.WriteLine("Your numbers added together equal: " +
                simplemath.AddNumbers(num1, num2));

            //transition to next method
            Console.WriteLine("Press enter to continue to next method:");
            Console.ReadLine();
            Console.Clear();

            //========================================================
            // Part Two                                             //
            //========================================================

            //get numbers from user
            Console.WriteLine("Please enter a decimal number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter another decimal number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //display answer to user
            Console.WriteLine("Your numbers added together equal: " +
                simplemath.AddNumbers(number1, number2));

            //transition to next method
            Console.WriteLine("Press enter to continue to next method:");
            Console.ReadLine();
            Console.Clear();

            //========================================================
            // Part Three                                           //
            //========================================================

            //get numbers from user
            Console.WriteLine("Please enter a number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //display answer to user
            Console.WriteLine("Your numbers added together equal: " +
                simplemath.AddNumbers(firstNumber, secondNumber));

            //end program
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
