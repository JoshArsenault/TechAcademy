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
                Console.Write(item + " ");
            }
            string chosenAttackMethod = Console.ReadLine();
            Console.Write("You chose the " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(chosenAttackMethod);
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("You advance to the next room.");
            System.Threading.Thread.Sleep(3000);

            //room 2
            Console.Write("You encounter the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wizard of Crescent Moons");
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
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
                System.Threading.Thread.Sleep(3000);
                Console.Write("Unamused, the wizard casts ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("fireball");
                Console.ResetColor();
                Console.Write(" on you");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine(" Oh dear. You are dead.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }
            Console.WriteLine("You chose door " + chosenDoor);
            System.Threading.Thread.Sleep(2000);
            Console.Clear();


            //room 3
            Console.Write("Well done, you have reached the end. You encounter a ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" treasure chest");
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
            foreach (string item in treasureLoot)
            {
                Console.WriteLine(item);
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Choose your reward: (1-5)");
            string uc = Console.ReadLine();
            int userChoice = Convert.ToInt32(uc);
            if (userChoice == 1)
            {
                Console.WriteLine("Congratulations, you have finished the gauntlet and earned a " + treasureLoot[0]);
                Console.ReadLine();
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("Congratulations, you have finished the gauntlet and earned a " + treasureLoot[1]);
                Console.ReadLine();
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("Congratulations, you have finished the gauntlet and earned a " + treasureLoot[2]);
                Console.ReadLine();
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("Congratulations, you have finished the gauntlet and earned a " + treasureLoot[3]);
                Console.ReadLine();
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Congratulations, you have finished the gauntlet and earned a " + treasureLoot[4]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You broke me somehow, well done!");
                Console.ReadLine();
            }
            Environment.Exit(0);

        }
    }
}