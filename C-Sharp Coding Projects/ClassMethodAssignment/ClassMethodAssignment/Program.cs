using System;

namespace ClassMethodAssignment
{
    static class Program
    {
        static void Main(string[] args)
        {
            //instantiate
            MultiplyOrDivide multOrDivide = new MultiplyOrDivide();

            //get number from user
            Console.WriteLine("Please enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //display result
            int result;
            multOrDivide.DivideByTwo(num1, out result);
            Console.WriteLine("Your number divided by two equals: " + result);

            //delay
            System.Threading.Thread.Sleep(4000);
            Console.Clear();

            //display result with parameters
            Console.WriteLine("This result of parameters (10,15) being multiplied is: ");
            Console.WriteLine(multOrDivide.MultiplyByTwo(10, 15));

            //delay
            System.Threading.Thread.Sleep(4000);
            Console.Clear();

            //static method
            Console.WriteLine("The number below was created using a static method:");
            Console.WriteLine(MultiplyOrDivide.SquareRoot());

            //program end
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
