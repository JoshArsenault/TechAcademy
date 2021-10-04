using System;

namespace StructsAssignment
{
    class Program
    {
        public struct Number
        {
            public decimal Amount { get; set; }
        }

        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.Amount = 15.95m;

            Console.WriteLine(num1.Amount);

            Console.ReadLine();
        }
    }
}
