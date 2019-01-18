using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string input = Console.ReadLine();

            var usersAndSides = new Dictionary <string, List<string>>();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] tockens = input.Split(" | ");
                    string username = tockens[1];
                    string forceside = tockens[0];
                    
                    if (!usersAndSides.ContainsKey(forceside))
                    {
                        usersAndSides.Add(forceside, new List<string>());
                    }
                    if (!usersAndSides[forceside].Contains(username))
                    {
                        usersAndSides[forceside].Add(username);
                    }
                }
                else
                {
                    string[] tockens = input.Split(" -> ");
                    string username = tockens[0];
                    string forceside = tockens[1];

                    foreach (var kvp in usersAndSides)
                    {
                        if (kvp.Value.Contains(username))
                        {
                            kvp.Value.Remove(username);
                            if (!usersAndSides.ContainsKey(forceside))
                            {
                                usersAndSides.Add(forceside, new List<string>());
                                usersAndSides[forceside].Add(username);
                                System.Console.WriteLine($"{username} joins the {forceside} side!");
                                break;    
                            }
                            else
                            {
                                usersAndSides[forceside].Add(username);
                                System.Console.WriteLine($"{username} joins the {forceside} side!");
                                break;     
                            }
                        }
                    }
                    if (!usersAndSides.ContainsKey(forceside))
                    {
                        usersAndSides.Add(forceside, new List<string>());
                        usersAndSides[forceside].Add(username);
                        System.Console.WriteLine($"{username} joins the {forceside} side!");       
                    }
                    else if (!usersAndSides[forceside].Contains(username))
                    {
                        usersAndSides[forceside].Add(username);
                        System.Console.WriteLine($"{username} joins the {forceside} side!");
                                
                    }        
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in usersAndSides
                                .OrderByDescending(x => x.Value.Count)
                                .ThenBy(x => x.Key))
            {
                if (kvp.Value.Count > 0)
                {
                    System.Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                    kvp.Value
                        .OrderBy(w => w)
                        .ToList()
                        .ForEach(x => System.Console.WriteLine($"! " + x));
                }
            }
        }
    }
}
