using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            int[] bombs = new int[2];
            bombs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> left = new List<int>();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombs[0])
                {
                    int index = i;
                    
                    for (int k = index; k >= 0; k--)
                    {
                        left.Add(numbers[k]);
                    }
                    for (int l = 0; l <= bombs[1]; l++)
                    {
                        if(left.Count == 0)
                        {
                            break;
                        }

                        left.RemoveAt(0);
                    }
                    
                    numbers.RemoveRange(0, index + 1);

                    for (int r = 0; r < bombs[1]; r++)
                    {
                        if (numbers.Count == 0)
                        {
                            break;
                        }

                        numbers.RemoveAt(0);
                    }

                    left.Reverse();
                    left.AddRange(numbers);
                    numbers.Clear();
                    numbers.AddRange(left);
                    left.Clear();
                    i = -1;
                }                
            }

            int sum = numbers.Sum();
            System.Console.WriteLine(sum);
        }
    }
}
