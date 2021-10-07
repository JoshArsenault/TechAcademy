using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //display current date to console
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current date: " + currentDate.ToString("MMMM dd, yyyy H:mm:ss"));

            //get alarm duration from user
            Console.WriteLine("How many hours from now do you want to set an alarm?");
            int hoursFromNow = Convert.ToInt32(Console.ReadLine());

            //assign alarm
            DateTime newCurrentDate = DateTime.Now.AddHours(hoursFromNow);

            //display alarm to console
            Console.WriteLine("Alarm set for: " + newCurrentDate.ToString("MMMM dd, yyyy H:mm:ss"));

            //delay
            Console.ReadLine();
        }
    }
}
