using System;
namespace ClassMethodAssignment
{
    public class MultiplyOrDivide
    {
        public void DivideByTwo(int num1, out int result)
        {
            result = num1 / 2;
        }

        public int MultiplyByTwo(int num1, int num2)
        {
            return num1 * num2;
        }

        //this is an overload method for decimal nums
        public double MultiplyByTwo(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double SquareRoot()
        {
            return Math.Sqrt(10);
        }
    }
}
