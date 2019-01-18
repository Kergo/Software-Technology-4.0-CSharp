using System;

namespace MultiplicationTable
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                System.Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
