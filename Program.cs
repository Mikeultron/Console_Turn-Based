/* 
*Author : Mikhael Esa Surya Wijaya
*Date   : 02/10/2020
*Github : https://github.com/Mikeultron/Console_Turn-Based
*/

using System;
using System.Threading;

namespace SmallGame
{
    class Program
    {
        // We instantiate the Human and Orc and give them name by constructor.
        static Human human = new Human("Kael");
        static Orc orc = new Orc("Brutus");

        // Instantiate Random to decide the skill casting.
        static Random rng = new Random();

        // Don't mind the syntax. This will just call the DecideTurn() 
        static void Main() => DecideTurn();

        // Function the check if game is over or not
        static bool IsGameOver()
        {
            if(human.Health <= 0 || orc.Health <= 0) return true;
            return false;
        }

        // This is the function for Human's turn
        static void HumanTurn()
        {
            // Check if health is <= 0?
            if(IsGameOver()){ 
                Console.WriteLine($"{human.Name} Win!");
                return;
            }
            Console.WriteLine("Human Turn");

            // Initialize the random number
            int rand = rng.Next(0, 101);

            // The casting chance of super skill is 20% and 80 % for basic skill.
            if(rand > 80)
            {
                human.CastSuperSkill();
                Thread.Sleep(1500);
                orc.Hit(human.Damage * 2);
                Thread.Sleep(1500);
            }
            else
            {
                human.CastBasicSkill();
                Thread.Sleep(1500);
                orc.Hit(human.Damage);
                Thread.Sleep(1500);
            }

            // Call OrcTurn() funtion
            OrcTurn();
        }

        // It works the same as HumanTurn()
        static void OrcTurn()
        {
            if(IsGameOver()){
                Console.WriteLine($"{orc.Name} Win!");
                return;
            }
            Console.WriteLine("Orc Turn");
            int rand = rng.Next(0, 101);
            if(rand > 80)
            {
                orc.CastSuperSkill();
                Thread.Sleep(1500);
                human.Hit(orc.Damage * 2);
                Thread.Sleep(1500);
            }
            else
            {
                orc.CastBasicSkill();
                Thread.Sleep(1500);
                human.Hit(orc.Damage);
                Thread.Sleep(1500);
            }
            HumanTurn();
        }

        // This function will decide who will attacks first.
        static void DecideTurn()
        {
            Console.Clear();
            Console.WriteLine("0 beats 1, 1 beats 2, 2 beats 0\n");
            Console.Write("Choose number between 0 - 2: ");
            
            // Getting user input and orc random number.
            int humanChoice = int.Parse(Console.ReadLine());
            int orcChoice = new Random().Next(0, 3);

            // Message after choosing number
            string message = $"Human: {humanChoice}\nOrc: {orcChoice}";
            Console.WriteLine(message);
            Thread.Sleep(2000);

            // Call this function again if both numbers are same or draw.
            if(orcChoice == humanChoice) DecideTurn();

            // Comparing the numbers.
            if(orcChoice == 0)
            {
                if(humanChoice == 1) OrcTurn();
                else HumanTurn();
            }
            else if(orcChoice == 1)
            {
                if(humanChoice == 2) OrcTurn();
                else HumanTurn();
            }
            else if(orcChoice == 2)
            {
                if(humanChoice == 0) OrcTurn();
                else HumanTurn();
            }
        }
    }
}