using System;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate week object
            Week DaysInWeek = new Week();

            //runs program
            DaysInWeek.GetDayInWeek();

            //delay & exit
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
