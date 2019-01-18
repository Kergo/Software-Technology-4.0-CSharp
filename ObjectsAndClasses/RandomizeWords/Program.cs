using System;

namespace RandomizeWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var ri = random.Next(0, words.Length);
                var tempValue = words[i];
                words[i] = words[ri];
                words[ri] = tempValue;
            }

            System.Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}