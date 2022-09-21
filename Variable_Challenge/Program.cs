using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Health;
            float score;
            float sheilds;
            float multi;
            float lives;

            Health = 50;
            sheilds = 150;
            multi = 1;
            score = 0;
            lives = 5;

            Console.WriteLine("The Chaddiest Game!!!");
            Console.WriteLine("");
            Console.WriteLine("Score:  " + score + " | " + "Lives: " + lives);
            Console.WriteLine("Health:" + Health + " | " + "Armour: " + sheilds);
            Console.WriteLine("Multiplyer: " + multi);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("You defeated 20 enemies.");
            Console.WriteLine("You took 10 points of damage.");
            Console.WriteLine("You gained 20 points.");
            Console.WriteLine("Your Multiplyer increased by 2 for going on a kill streak.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            score = 10;
            sheilds = sheilds - 10;
            multi = multi * 2;

            Console.WriteLine("The Chaddiest Game!!!");
            Console.WriteLine("");
            Console.WriteLine("Score:  " + score + " | " + "Lives: " + lives);
            Console.WriteLine("Health:" + Health + " | " + "Armour: " + sheilds);
            Console.WriteLine("Multiplyer: " + multi);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("You defeated a mini boss.");
            Console.WriteLine("Howver you died by it's minions in the process.");
            Console.WriteLine("You gained 150 points.");
            Console.WriteLine("Your Multiplyer decreased to 1 from passing away.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            score = (score * 15) * 2;
            sheilds = sheilds + 10;
            multi = multi / 2;
            lives = lives - 1;
            score = score + 10;


            Console.WriteLine("The Chaddiest Game!!!");
            Console.WriteLine("");
            Console.WriteLine("Score:  " + score + " | " + "Lives: " + lives);
            Console.WriteLine("Health:" + Health + " | " + "Armour: " + sheilds);
            Console.WriteLine("Multiplyer: " + multi);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("You found a armour pack.");
            Console.WriteLine("You pick it up and oversheild by 50.");

            Console.WriteLine("");
            Console.WriteLine("");

            sheilds = sheilds + 50;

            Console.WriteLine("The Chaddiest Game!!!");
            Console.WriteLine("");
            Console.WriteLine("Score:  " + score + " | " + "Lives: " + lives);
            Console.WriteLine("Health:" + Health + " | " + "Armour: " + sheilds);
            Console.WriteLine("Multiplyer: " + multi);





            Console.ReadKey(true);









        }
    }
}
