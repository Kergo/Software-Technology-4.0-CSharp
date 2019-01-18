using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtractFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string[] parts = path.Split('\\');
            string file = parts[parts.Length - 1]; 
            string fileName = file.Split('.').First();
            string extension = file.Split('.').Last();

            System.Console.WriteLine($"File name: {fileName}");
            System.Console.WriteLine($"File extension: {extension}");
        }
    }
}
