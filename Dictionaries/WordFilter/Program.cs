using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}