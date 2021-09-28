using System;

namespace InterfacesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate employee
            Employee employee = new Employee() { FirstName = "Josh", LastName = "Arsenault", isEmployee = true };

            //terminate employee
            Console.WriteLine("Do you want to fire " + employee.FirstName + " " + employee.LastName + "?");
            string input = Convert.ToString(Console.ReadLine());

            //deciding whether to terminate employee
            if (input == "yes")
            {
                employee.isEmployee = false;
            }
            else
            {
                employee.isEmployee = true;
            }

            //report results
            Console.WriteLine("The employee status of " + employee.FirstName + " " + employee.LastName + " is " + employee.isEmployee);
            Console.ReadLine();
        }
    }
}
