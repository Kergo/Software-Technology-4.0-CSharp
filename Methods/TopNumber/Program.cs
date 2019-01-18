using System;

namespace TopNumber
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                OddDigitChecker(i);
            }
        }

        public static void OddDigitChecker(int num)
        {
            int checker = num;

            while (checker > 0)
            {
                if (checker % 2 != 0)
                {
                    PrintIfDivisibleByEight(num);
                    break;
                }
                
                checker = checker / 10;
            }
        }
        public static void PrintIfDivisibleByEight(int oddDigit)
        {
            int sum = 0;
            int num = oddDigit;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;       
            }

            if (sum % 8 == 0)
            {
                System.Console.WriteLine(oddDigit);
            }
        }
    }
}
