using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceRepeatingChars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var output = new StringBuilder();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    output.Append(input[i]);
                }
            }

            output.Append(input.Last());
            Console.WriteLine(output);
        }
    }
}