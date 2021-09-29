using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //create employees
            Employee employee1 = new Employee() { Id = 1, FirstName = "Josh", LastName = "Arsenault" };
            Employee employee2 = new Employee() { Id = 2, FirstName = "Frodo", LastName = "Baggins" };

            //display result
            Console.WriteLine(employee1.Id == employee2.Id);
            Console.ReadLine();
        }
    }
}
