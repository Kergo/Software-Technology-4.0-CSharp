using System;
using System.Collections.Generic;
using System.Linq;

namespace MinerTask
{
     public class Program
    {
        public static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            var resources = new Dictionary<string, long>();

            while (resource != "stop")
            {
               int quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }

                resources[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var kvp in resources)
            {
                System.Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}