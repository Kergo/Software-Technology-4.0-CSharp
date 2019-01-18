using System;

namespace SumOfOddNumbers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num * 2; i += 2)
            {
                System.Console.WriteLine(i);
                sum += num;
            }
            System.Console.WriteLine($"Sum: {sum}");
        }
    }
}
