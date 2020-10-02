using System;
using System.Threading;

namespace SmallGame
{
    class Program
    {
        static Human human = new Human("Kael");
        static Orc orc = new Orc("Brutus");
        static Random rng = new Random();
        static void Main() => DecideTurn();
        static bool IsGameOver()
        {
            // 0 beats 1, 1 beats 2, 2 beats 0
            if(human.Health <= 0 || orc.Health <= 0)
                return true;
            return false;
        }

        static void HumanTurn()
        {
            if(IsGameOver()){ 
                Console.WriteLine($"{human.Name} Win!");
                return;
            }
            Console.WriteLine("Human Turn");
            int rand = rng.Next(0, 101);
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
            OrcTurn();
        }

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

        static void DecideTurn()
        {
            Console.Clear();
            Console.WriteLine("0 beats 1, 1 beats 2, 2 beats 0\n");
            Console.Write("Choose number between 0 - 2: ");
            int humanChoice = int.Parse(Console.ReadLine());
            int orcChoice = new Random().Next(0, 3);
            string message = $"Human: {humanChoice}\nOrc: {orcChoice}";
            Console.WriteLine(message);
            Thread.Sleep(2000);
            if(orcChoice == humanChoice) DecideTurn();
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