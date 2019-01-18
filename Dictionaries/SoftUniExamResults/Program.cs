using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string input = Console.ReadLine();

            //Save max points
            //If user is banned points = 0
            var participantsAndPoints = new Dictionary<string, int>();
            //
            var languageAndSubmissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] tockens = input.Split("-");
                string username = tockens[0];

                if (tockens.Length == 2)
                {
                    participantsAndPoints[username] = 0;
                }
                else
                {
                    string language = tockens[1];
                    int points = int.Parse(tockens[2]);
                
                    if (!participantsAndPoints.ContainsKey(username))
                    {
                        participantsAndPoints.Add(username, 0);
                    }
                    if (participantsAndPoints[username] < points)
                    {
                        participantsAndPoints[username] = points;
                    }
                    if (!languageAndSubmissions.ContainsKey(language))
                    {
                        languageAndSubmissions.Add(language, 0);
                    }
                    languageAndSubmissions[language]++;
                }

                input = Console.ReadLine();
            }

            System.Console.WriteLine("Results:");
            foreach (var kvp in participantsAndPoints
                                .OrderByDescending(x => x.Value)
                                .ThenBy(w => w.Key))
            {
                if (kvp.Value > 0)
                {
                    System.Console.WriteLine($"{kvp.Key} | {kvp.Value}");                    
                }
            }

            System.Console.WriteLine("Submissions:");
            foreach (var kvp in languageAndSubmissions
                                .OrderByDescending(x => x.Value)
                                .ThenBy(w => w.Key))
            {
                System.Console.WriteLine($"{kvp.Key} - {kvp.Value}");                
            }
        }
    }
}
