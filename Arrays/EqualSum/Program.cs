using System;
using System.Linq;
namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            if (numbers.Length <= 1)
            {
                System.Console.WriteLine(0);
                return;
            }
            int equalSumsCounter = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }              
                if (leftSum == rightSum)
                {
                    System.Console.WriteLine(i);
                    equalSumsCounter++;
                }
            }   
            if (equalSumsCounter == 0)
            {
                System.Console.WriteLine("no");
            }
        }
    }
}
