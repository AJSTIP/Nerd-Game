using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nerd_game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player.certifiedHoodClassic();
            Console.ReadKey();
        }
       
    }

    public class Player
    {
        public static void certifiedHoodClassic()
        {
            Console.WriteLine("How many players do you have? 2-8");

            int playerCount  = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What's the Player's name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("What's the Player's age?");
            int playerAge = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();
            double playerLuck = rand.Next(0, 10);
            int playerRoll = rand.Next(1, 10);
            



            Console.WriteLine($"You have {playerCount} players.");
            Console.WriteLine($"Player name is {playerName}.");
            Console.WriteLine($"Player age is {playerAge}.");
            Console.WriteLine($"Player luck is 1.{playerLuck}.");
            Console.WriteLine($"Player roll is {playerRoll}.");
        }
    }
}
