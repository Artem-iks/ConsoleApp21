using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            int experience = 208613;
            int MaxXp = 239503;
            int level = 54;
            int health = 9218;
            int maxHealth = 9218;
            int endurance = 149;
            int maxEndurance = 149;
            int break1 = 3;
            int toughness = 16;
            int minattack = 943;
            int maxsttack = 1014;
            int defense = 749;
            double crit = 0.41;
            double critdmg = 1.58;
            int luck = 482;
            int rep = 38193;
            int vaxrep = 150000;
        }
            //2 Я взяв персонажа еллі з The last of us 2
            public class EllieTLOU2
        {
            public string name = "Ellie";
            public int age = 19;
            public int hp = 100;
            public int Maxhp = 10;
             public int Parts = 40;
            public bool Isvis = false;
        }
        //3
        public class Player
        {
            public string Name;
            public int TotalScore;
        }

        static void Main()
        {
            Player p1 = new Player { Name = "Гравець 1", TotalScore = 0 };
            Player p2 = new Player { Name = "Гравець 2", TotalScore = 0 };

            for (int r = 1; r <= 10; r++)
            {
                Console.WriteLine($"Раунд {r}");

                int s1 = oneRound(p1);
                int s2 = oneRound(p2);

                if (s1 > s2) Console.WriteLine($"Виграв: {p1.Name}");
                else if (s2 > s1) Console.WriteLine($"Виграв: {p2.Name}");
                else Console.WriteLine("Нічия");
            }

            Console.WriteLine($"\nРезультат:");
            Console.WriteLine($"{p1.Name}: {p1.TotalScore}");
            Console.WriteLine($"{p2.Name}: {p2.TotalScore}");

            if (p1.TotalScore > p2.TotalScore) Console.WriteLine($"Переміг: {p1.Name}");
            else if (p2.TotalScore > p1.TotalScore) Console.WriteLine($"Переміг: {p2.Name}");
            else Console.WriteLine("Нічия в грі");
        }

        static int RollDice()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }

        static int oneRound(Player p)
        {
            int d1 = RollDice();
            int d2 = RollDice();
            int sum = d1 + d2;
            p.TotalScore += sum;
            Console.WriteLine($"{p.Name}: {d1} + {d2} = {sum}");
            return sum;
        }
        //4 не завезли





    }
    }

