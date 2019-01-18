using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerOne.Count != 0 && playerTwo.Count != 0)
            {
                if (playerOne.ElementAt(0) > playerTwo.ElementAt(0))
                {
                    playerOne.Add(playerOne[0]);
                    playerOne.Add(playerTwo[0]);
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                else if (playerOne.ElementAt(0) < playerTwo.ElementAt(0))
                {
                    playerTwo.Add(playerTwo[0]);
                    playerTwo.Add(playerOne[0]);
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                else
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0); 
                }
            }

            if (playerOne.Count > playerTwo.Count)
            {
                int sum = playerOne.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = playerTwo.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
