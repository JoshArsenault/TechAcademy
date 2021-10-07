using System;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number
            Console.WriteLine("Please enter a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //write input to text file
            using (StreamWriter file = new StreamWriter(@"/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/FileIOAssignment/FileIOAssignment/log.txt"))
            {
                file.WriteLine(userNumber);
            };

            //outro
            Console.WriteLine(userNumber + " has been logged.");
            Console.ReadLine();
        }
    }
}
