using System;
namespace AbstractClassesAssignment
{
    public abstract class Person
    {
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
