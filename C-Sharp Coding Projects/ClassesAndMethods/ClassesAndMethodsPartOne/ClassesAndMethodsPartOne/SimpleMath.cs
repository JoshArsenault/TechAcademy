using System;
namespace ClassesAndMethodsPartOne
{
    public class SimpleMath
    {
        //adding "integer" types
        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        //adding "double" types
        public double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        //adding "string" types
        public int AddNumbers(string num1, string num2)
        {
            int firstNumber = Convert.ToInt32(num1);
            int secondNumber = Convert.ToInt32(num2);
            return firstNumber + secondNumber;
        }
    }
}
