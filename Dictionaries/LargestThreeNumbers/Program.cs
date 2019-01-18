using System;
using System.Linq;
using System.Collections.Generic;

namespace LargestThreeNumbers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();

            System.Console.WriteLine(string.Join(" ", list));
        }
    }
}