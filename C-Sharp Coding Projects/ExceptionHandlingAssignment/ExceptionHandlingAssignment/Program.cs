using System;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            bool isValid = false; //default
            DateTime currentDate = DateTime.Now;

            //display current date
            Console.WriteLine("Current date: " + currentDate.ToString("MMMM dd yyyy"));

            //container
            while (isValid == false)
            {
                try
                {
                    Console.WriteLine("Please enter your age");
                    try
                    {
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You were born: " + currentDate.AddYears(-age).ToString("MMMM dd yyyy"));
                        Console.ReadLine();
                        isValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Something went wrong");
                        Console.WriteLine("Please enter your age");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You were born: " + currentDate.AddYears(-age).ToString("MMMM dd yyyy"));
                        Console.ReadLine();
                        isValid = true;
                        Console.ReadLine();
                        return;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Please enter a valid age");
                    Console.ReadLine();
                    return;
                }
            }

            //delay
            Console.ReadLine();
        }
    }
}
