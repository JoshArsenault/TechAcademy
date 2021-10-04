using System;
namespace EnumsAssignment
{
    public class Week
    {
        public enum DaysInWeek
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        public void Retry()
        {
            Console.WriteLine("Nice try. Please enter a valid number.");
            Console.ReadLine();
            Console.Clear();
            GetDayInWeek();
        }

        public void GetDayInWeek()
        {
            //get details from user
            Console.WriteLine("Please enter current day of the week");
            Console.WriteLine("1: Sunday, 2: Monday, 3: Tuesday, 4: Wednesday, 5: Thursday, 6: Friday, 7: Saturday");
            int input = Convert.ToInt32(Console.ReadLine());
            string currentDay = null;

            //generate current day from enums
            try
            {
                if (input == 1) { currentDay = DaysInWeek.Sunday.ToString(); }
                else if (input == 2) { currentDay = DaysInWeek.Monday.ToString(); }
                else if (input == 3) { currentDay = DaysInWeek.Tuesday.ToString(); }
                else if (input == 4) { currentDay = DaysInWeek.Wednesday.ToString(); }
                else if (input == 5) { currentDay = DaysInWeek.Thursday.ToString(); }
                else if (input == 6) { currentDay = DaysInWeek.Friday.ToString(); }
                else if (input == 7) { currentDay = DaysInWeek.Saturday.ToString(); }
                else { Retry(); }

                Console.WriteLine("The current day is: " + currentDay);
            }
            catch
            {
                throw new NotImplementedException();
            }
            Console.ReadLine();
        }
    }
}
