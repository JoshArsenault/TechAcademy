using System;

namespace OperatorOverloading
{
    public class Employee
    {
        //properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator == (Employee emp1, Employee emp2)
        {
            if (emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (!emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;
        }
    }
}
