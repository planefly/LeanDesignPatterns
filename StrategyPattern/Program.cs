using System;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int seed1 = 10;
            int seed2 = 20;

            Player player1 = new Player("Taro", new WinningStrategy(seed1));
            Player player2 = new Player("Hana", new ProbStrategy(seed2));
            for (int i = 0; i < 1000; i++)
            {
                Hand hand1 = player1.NextHand();
                Hand hand2 = player2.NextHand();

                if (hand1.IsStrongerThan(hand2))
                {
                    Console.WriteLine($"Winner: {player1}");
                    player1.Win();
                    player2.Lose();
                }
                else if (hand2.IsStrongerThan(hand1))
                {
                    Console.WriteLine($"Winner: {player2}");
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine($"Even...");
                    player1.Even();
                    player2.Even();
                }
            }

            Console.WriteLine("Total result:");
            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());

        }
    }
}
