using System;
using System.Collections.Generic;

namespace AdditionalFeaturesAssignment
{
    public class Developer
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //add developer construct1
        public Developer(string firstName)
        {
            this.FirstName = firstName;
        }

        //add developer construct2
        public Developer(string firstName, string LastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }
    }
}
