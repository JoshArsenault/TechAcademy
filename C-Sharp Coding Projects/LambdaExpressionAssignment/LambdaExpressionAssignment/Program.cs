using System;
using System.Collections.Generic;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate employees
            Employee e1 = new Employee() { Id = 1, FirstName = "Josh", LastName = "Arsenault" };
            Employee e2 = new Employee() { Id = 2, FirstName = "Joe", LastName = "Jonders" };
            Employee e3 = new Employee() { Id = 3, FirstName = "Bill", LastName = "Nightcrawler" };
            Employee e4 = new Employee() { Id = 4, FirstName = "Ned", LastName = "Smith" };
            Employee e5 = new Employee() { Id = 5, FirstName = "Tim", LastName = "Johnson" };
            Employee e6 = new Employee() { Id = 6, FirstName = "George", LastName = "Fletcher" };
            Employee e7 = new Employee() { Id = 7, FirstName = "Mary", LastName = "Dawson" };
            Employee e8 = new Employee() { Id = 8, FirstName = "Melissa", LastName = "Wentworth" };
            Employee e9 = new Employee() { Id = 9, FirstName = "Claire", LastName = "Sharp" };
            Employee e10 = new Employee() { Id = 11, FirstName = "Joe", LastName = "Arsenault" };

            //add employees to list
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(e1);
            EmployeeList.Add(e2);
            EmployeeList.Add(e3);
            EmployeeList.Add(e4);
            EmployeeList.Add(e5);
            EmployeeList.Add(e6);
            EmployeeList.Add(e7);
            EmployeeList.Add(e8);
            EmployeeList.Add(e9);
            EmployeeList.Add(e10);
        }
    }
}
