using System;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare intro
            const string intro = "Hello, my name is: ";

            //create new dev
            var newHire = new Developer(firstName : "Josh", LastName : "Arsenault");

            //write to console
            Console.WriteLine(intro + "{0} {1}", newHire.FirstName, newHire.LastName);

            //delay
            Console.ReadLine();
        }
    }
}
