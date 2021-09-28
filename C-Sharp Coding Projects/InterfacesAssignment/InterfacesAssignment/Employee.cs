using System;
namespace InterfacesAssignment
{
    public class Employee : IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        //declaring variables
        public bool isEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
