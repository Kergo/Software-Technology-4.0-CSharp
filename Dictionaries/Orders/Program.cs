using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var productsQuantity = new Dictionary<string, int>();
            var productsPrice = new Dictionary<string, double>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] tockens = input.Split();
                string name = tockens[0];
                double price = double.Parse(tockens[1]);
                int quantity = int.Parse(tockens[2]);

                if (!productsQuantity.ContainsKey(name))
                {
                    productsQuantity.Add(name, 0);
                    productsPrice.Add(name, 0);
                }
                productsQuantity[name] += quantity;
                productsPrice[name] = price;

                input = Console.ReadLine();
            }

            foreach (var kvp in productsPrice)
            {
                string product = kvp.Key;
                int quantity = productsQuantity[product];
                double price = kvp.Value;

                System.Console.WriteLine($"{product} -> {quantity * price:f2}");   
            }
        }
    }
}