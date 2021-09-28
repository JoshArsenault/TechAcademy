using System;

namespace AbstractClassesAssignment
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
