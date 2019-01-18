using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsernames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(", ").ToList();
            var validUsernames = new List<string>();

            foreach (var name in usernames)
            {
                if (name.Length >= 3 && name.Length <= 16)
                { 
                    if(name.ToCharArray().All(ch => ch >= 65 && ch <= 122 || ch >= 48 && ch <= 57 || ch == 45))
                    {
                     validUsernames.Add(name);   
                    }  
                }
            }

            validUsernames.ForEach(x => System.Console.WriteLine(x));
        }
    }
}