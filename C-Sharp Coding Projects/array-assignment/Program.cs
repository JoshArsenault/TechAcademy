using System;
using System.Collections.Generic;
using System.Linq;

namespace array_assignment
{
    class Program
    {
        static void Main()
        {

            //define attack methods
            string[] attackMethod = { "Sword", "Shield", "Hammer", "Fists" };

            //define attack power
            int[] doorNumber = { 1, 2, 3, 4, 5, 6 };

            //define treasure chest loot
            List<string> treasureLoot = new List<string>();
            treasureLoot.Add("Golden compass");
            treasureLoot.Add("Rod of eternity");
            treasureLoot.Add("Chicken Sceptre");
            treasureLoot.Add("Disc of Returning");
            treasureLoot.Add("Photon Collider");

            //intro to the gauntlet
            Console.Write("Welcome to the ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Eternum Gauntlet");
            System.Threading.Thread.Sleep(3000);
            Console.ResetColor();
            Console.Write("You will be asked a series of questions. Make your choice to progress the gauntlet and reach the end where the");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" treasure ");
            Console.ResetColor();
            Console.WriteLine("awaits.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            //room 1
            Console.WriteLine("You're presented with an option to choose a weapon.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("What do you choose?");
            foreach (string item in attackMethod)
            {
                Console.WriteLine(item);
            }
            string chosenAttackMethod = Console.ReadLine();
            Console.WriteLine("You chose the " + chosenAttackMethod);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You advance to the next room.");
            System.Threading.Thread.Sleep(2000);

            //room 2
            Console.Write("You encounter the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wizard of Crescent Moons");
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("He presents you with 6 doors, which door do you choose?");
            foreach (int item in doorNumber)
            {
                Console.Write(item + "  ");
            }
            string cd = Console.ReadLine();
            int chosenDoor = Convert.ToInt32(cd);
            if (chosenDoor > 6 || chosenDoor == 0)
            {
                Console.WriteLine("The wizard looks at you with an unpleasant grin");
                System.Threading.Thread.Sleep(2000);
                Console.Write("Unamused, the wizard casts ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("fireball");
                Console.ResetColor();
                Console.WriteLine(" on you");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("You are dead.");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }
            Console.WriteLine("You chose door " + chosenDoor);
            

            //room 3

        }
    }
}