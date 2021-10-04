using System;
using System.Collections.Generic;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //first employee
            Employee<string> EmployeeOne = new Employee<string>();
            EmployeeOne.Things.Add("Goldfish");
            EmployeeOne.Things.Add("Bucket of buckets");
            EmployeeOne.Things.Add("Gum from under his seat");

            //second employee
            Employee<int> EmployeeTwo = new Employee<int>();
            EmployeeTwo.Things.Add(15);
            EmployeeTwo.Things.Add(20);
            EmployeeTwo.Things.Add(30);

            //loop
            foreach (string thingStr in EmployeeOne.Things)
            {
                foreach (int thingInt in EmployeeTwo.Things)
                {
                    Console.WriteLine(thingStr + thingInt);
                }
            }
            Console.ReadLine();
        }
    }
}
