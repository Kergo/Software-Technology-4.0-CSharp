using System;

namespace VowelsCount
{
   public class Program
    {
       public static void Main(string[] args)
        {
            PrintVowelsCount(Console.ReadLine());
        }
        public static void PrintVowelsCount(string text)
        {
            int vowelsCount = 0;

            foreach (char ch in text.ToLower())
            {
               if (ch == 'a' || ch == 'e' || ch == 'o' || ch == 'u' || ch == 'i')
               {
                   vowelsCount++;
               } 
            }
            System.Console.WriteLine(vowelsCount);
        }
    }
}
