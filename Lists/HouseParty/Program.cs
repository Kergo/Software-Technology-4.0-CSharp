using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int commandsLength = int.Parse(Console.ReadLine());

            List<string> guestsAttending = new List<string>();

            for (int i = 0; i < commandsLength; i++)
            {

                string input = Console.ReadLine();

                if (input.Split().Length == 3)
                {
                    if(guestsAttending.Contains(input.Split()[0]))
                    {
                        System.Console.WriteLine($"{input.Split()[0]} is already in the list!");
                    }
                    else
                    {
                        guestsAttending.Add(input.Split()[0]);
                    }               
                }
                else
                {
                    if (guestsAttending.Contains(input.Split()[0]))
                    {
                        guestsAttending.Remove(input.Split()[0]);
                    }
                    else
                    {
                        System.Console.WriteLine($"{input.Split()[0]} is not in the list!");
                    }
                }
            }

            System.Console.WriteLine(string.Join("\n", guestsAttending));
        }
    }
}
