using System;

namespace SumDigits
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }

            System.Console.WriteLine(sum);
        }
    }
}
