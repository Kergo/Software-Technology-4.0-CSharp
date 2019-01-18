using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<int> someList = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input.Split(' ')[0] == "Delete")
                {
                    for (int i = 0; i < someList.Count; i++)
                    {
                        if (someList[i] == int.Parse(input.Split(' ')[1]))
                        {
                            someList.RemoveAt(i);
                            i = -1;
                        }
                    }
                }
                else if (input.Split(' ')[0] == "Insert")
                {
                    someList.Insert(int.Parse(input.Split(' ')[2]), int.Parse(input.Split(' ')[1]));
                }

                input = Console.ReadLine();
            }

            System.Console.WriteLine(string.Join(' ', someList));
        }
    }
}