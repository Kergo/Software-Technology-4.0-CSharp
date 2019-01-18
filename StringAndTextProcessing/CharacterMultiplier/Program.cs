using System;
using System.Linq;
using System.Collections.Generic;

namespace CharacterMultiplier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string first = input.Split(' ').First();
            string second = input.Split(' ').Last();
            Console.WriteLine(CharMultiplier(first, second));      
        }

        public static int CharMultiplier(string firstText, string secondText)
        {
            int sum = 0;
            var charsFirst = firstText.ToCharArray();
            var charsSecond = secondText.ToCharArray();
            int count = 0;

            if (charsFirst.Length > charsSecond.Length)
            {
                count = charsSecond.Length;
                for (int i = count; i < charsFirst.Length; i++)
                {
                    sum += charsFirst[i];
                }
            }
            else if (charsSecond.Length > charsFirst.Length)
            {
                count = charsFirst.Length;
                for (int i = count; i < charsSecond.Length; i++)
                {
                    sum += charsSecond[i];
                }
            }
            else
            {
                count = charsFirst.Length;
            }

            for (int i = 0; i < count; i++)
            {
                int currChar = 0;
                currChar = charsFirst[i] * charsSecond[i];
                sum += currChar;
            }

            return sum;
        }
    }
}
