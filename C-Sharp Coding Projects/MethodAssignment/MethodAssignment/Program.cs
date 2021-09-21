using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //get numbers from user
            Console.WriteLine("Please enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //instanciate methods
            Methods methods = new Methods();

            //display each math function to user
            Console.WriteLine("Your numbers added together: " +
                methods.AddTwoNumbers(number1, number2));

            Console.WriteLine("Your numbers divided together: " +
                methods.DivideTwoNumbers(number1, number2));

            Console.WriteLine("Your numbers multiplied together: " +
                methods.MultiplyTwoNumbers(number1, number2));

            Console.ReadLine();
        }
    }
}
