using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input.Split(' ')[0] == "Add")
                {
                    wagons.Add(int.Parse(input.Split(' ')[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + int.Parse(input)) <= wagonCapacity)
                        {
                            wagons[i] = wagons[i] + int.Parse(input);
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            System.Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
