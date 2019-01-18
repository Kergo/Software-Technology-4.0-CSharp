using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string[] bladi = Console.ReadLine().Split('|')
            .Reverse()
            .Select(line => string
            .Join(" ", line
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)))
            .ToArray();
            Console.WriteLine(string.Join(' ', bladi));
        }
    }
}
