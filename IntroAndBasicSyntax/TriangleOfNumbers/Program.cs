using System;

namespace TriangleOfNumbers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(i + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
