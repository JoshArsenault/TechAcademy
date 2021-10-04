using System;
using System.Collections.Generic;

namespace GenericsAssignment
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }
}
