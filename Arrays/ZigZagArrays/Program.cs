using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arrOne = new int[length];
            int[] arrTwo = new int[length];

            for (int i = 0; i < length; i++)
            {
                int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                if (i % 2 == 0)
                {
                    arrOne[i] = numbers[0];
                    arrTwo[i] = numbers[1];
                }

                else
                {
                    arrOne[i] = numbers[1];
                    arrTwo[i] = numbers[0];
                }
            }

            for (int i = 0; i < length; i++)
            {
                System.Console.Write($"{arrOne[i]} ");
            }
            System.Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                System.Console.Write($"{arrTwo[i]} ");                
            }
        }
    }
}