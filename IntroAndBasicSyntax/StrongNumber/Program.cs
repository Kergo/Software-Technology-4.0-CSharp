using System;

namespace StrongNumber
{
   public class Program
    {
       public static void Main(string[] args)
        {
            
            int inputNumber = int.Parse(Console.ReadLine());
            int strong = inputNumber;
            int result = 1;
            int factorialSum = 0;
            while (inputNumber > 0)
            {
                for (int j = 1; j <= inputNumber % 10; j++)
                {
                    result *= j;
                }
                factorialSum += result;
                result = 1;
                inputNumber /= 10;
            }
            if (strong == factorialSum)
            {
                System.Console.WriteLine("yes");
            }
            else
            {
                System.Console.WriteLine("no");
            }
        }
    }
}
