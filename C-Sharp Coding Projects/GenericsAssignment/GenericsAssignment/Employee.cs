using System;
using System.Collections.Generic;

namespace GenericsAssignment
{
    public class Employee<T>
    {
        public string Name { get; set; }
        public List<T> Things { get; set; }
    }
}
