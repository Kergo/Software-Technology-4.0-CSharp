using System;
using System.Linq;
using System.Collections.Generic;

namespace Pokemon
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> removed = new List<int>();

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int catched = pokemons.First();
                    removed.Add(catched);
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons.Last());
                    IncreaseDecrease(pokemons, catched);
                }
                else if (index >= pokemons.Count)
                {
                    int catched = pokemons.Last();
                    removed.Add(catched);
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons.First());
                    IncreaseDecrease(pokemons, catched);
                }
                else
                {
                    int catched = pokemons.ElementAt(index);
                    removed.Add(catched);
                    pokemons.RemoveAt(index);
                    IncreaseDecrease(pokemons, catched);
                }
            }

            Console.WriteLine(removed.Sum());
        }

        private static void IncreaseDecrease(List<int> pokemons, int catched)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= catched)
                {
                    pokemons[i] += catched;
                }
                else
                {
                    pokemons[i] -= catched;
                }
            }
        }
    }
}
