using System;

namespace MultiplicationTable2._0
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier > 10)
            {
                System.Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            }
            else
            {
                for (int i = multiplier; i < 11; i++)
                {
                System.Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
        }
    }
}
