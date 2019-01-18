using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            var charCount = new Dictionary<char, int>();

            foreach (var item in text)
            {
                if (!charCount.ContainsKey(item))
                {
                    charCount.Add(item, 0);
                }

                charCount[item]++;
            }

            charCount.Remove(' ');

            foreach (var item in charCount)
            {
                System.Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}