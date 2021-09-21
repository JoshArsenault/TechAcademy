using System;

namespace ClassesAndMethodsPartThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciate "VoidMethod"
            VoidMethod voidMethod = new VoidMethod();

            //display result to user
            voidMethod.NumberManipulation();
            System.Threading.Thread.Sleep(3000);

            //display results including name
            voidMethod.NumberManipulation(100, 1000);
            System.Threading.Thread.Sleep(3000);

            //delay before exiting app
            Console.ReadLine();
            Environment.Exit(0);
            

        }
    }
}
