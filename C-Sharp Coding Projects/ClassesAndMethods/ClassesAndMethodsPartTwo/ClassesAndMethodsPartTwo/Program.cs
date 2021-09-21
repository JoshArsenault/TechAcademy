using System;
using System.Windows.Input;

namespace ClassesAndMethodsPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciate "Methods"
            Methods methods = new Methods();

            //ask user for numbers
            Console.WriteLine("Please enter a whole number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optional: enter another whole number");
            Console.WriteLine("Note: leaving this blank will default to 1");
            string result = Console.ReadLine();

            //optional second number pathing
            if (result == "")
            {
                int num2 = 1;
                Console.WriteLine("Your result is: " +
                    methods.MultiplyNumbers(num1, num2));
            }
            else
            {
                int num2 = Convert.ToInt32(result);
                Console.WriteLine("Your result is: " +
                    methods.MultiplyNumbers(num1, num2));
            }

            //delay before exiting
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
