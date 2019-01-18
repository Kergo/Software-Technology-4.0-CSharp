using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CaesarCipher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var chars = input.ToCharArray();
            var encryptedText = new StringBuilder();   

            for (int i = 0; i < chars.Length; i++)
            {
                int charAsNum = chars[i];
                charAsNum += 3;
                var newChar = char.ConvertFromUtf32(charAsNum);
                encryptedText.Append(newChar);
            }

            System.Console.WriteLine(encryptedText);
        }
    }
}