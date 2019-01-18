using System;

namespace PrintAndSum
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                System.Console.Write(i + " ");
                sum += i;
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Sum: {sum}");
        }
    }
}
