using System;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();

            //delay
            Console.ReadLine();
        }
    }
}
