using System;
using System.Linq;
using System.Collections.Generic;

namespace CountNumbers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            var counts = new SortedDictionary<int, int>();

            foreach (int num in numbers)
            {
                if (!counts.ContainsKey(num))
                {
                    counts.Add(num, 0);
                }

                counts[num]++;
            }        
            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");                
            }
        }
    }
}