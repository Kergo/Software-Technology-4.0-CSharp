using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrences
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string [] words = Console.ReadLine().Split();

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts.Add(wordInLowerCase, 0);
                }

                counts[wordInLowerCase]++;
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    System.Console.Write(count.Key + " ");
                }
            }
        }
    }
}