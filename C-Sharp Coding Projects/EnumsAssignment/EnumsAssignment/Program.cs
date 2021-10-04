using System;
using System.Collections.Generic;

namespace EnumsAssignment
{
    class Program
    {
        public enum DaysInWeek {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day");
                string input = Console.ReadLine();

                DaysInWeek day = (DaysInWeek)Enum.Parse(typeof(DaysInWeek), input);

                Console.WriteLine("The current day is " + day);

                Console.ReadLine();
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
