using System;
using System.Collections.Generic;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //employee one
            Employee<string> EmployeeOne = new Employee<string>();
            EmployeeOne.Things = new List<string>();
            EmployeeOne.Things.Add("Chicken");
            EmployeeOne.Things.Add("Turkey");
            EmployeeOne.Things.Add("Salmon");

            //employee two
            Employee<int> EmployeeTwo = new Employee<int>();
            EmployeeTwo.Things = new List<int>();
            EmployeeTwo.Things.Add(15);
            EmployeeTwo.Things.Add(20);
            EmployeeTwo.Things.Add(30);

            //loop through things
            foreach (string thing in EmployeeOne.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in EmployeeTwo.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
