using System;
using System.Numerics;

namespace FactorialDivision
{
   public class Program
    {
       public static void Main(string[] args)
        {
            long firstFactorial = Factorial(int.Parse(Console.ReadLine()));
            long secondFactorial = Factorial(int.Parse(Console.ReadLine()));
            long divisionOfFactorials = firstFactorial / secondFactorial;
            System.Console.WriteLine(divisionOfFactorials.ToString("n2"));
        }

        public static long Factorial(int num)
        {            
            long result = num;
            if (num == 0)
            {
                return 1;
            }

            for (int i = 1; i < num; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
