using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }

        public decimal CalculatePricePerBox(int quantity, decimal price)
        {
            return quantity * price;
        }        
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            var boxes = new List<Box>();

            while (input != "end")
            {
                string[] tockens = input.Split();
                string serialNumber = tockens[0];
                string itemName = tockens[1];
                decimal itemPrice = decimal.Parse(tockens[3]);
                int quantity = int.Parse(tockens[2]);
                
                var box = new Box();

                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.Quantity = quantity;
                box.PriceBox = quantity * itemPrice;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            var sortedBoxes = boxes.OrderByDescending(b => b.PriceBox);

            foreach (var box in sortedBoxes)
            {
                System.Console.WriteLine($"{box.SerialNumber}");
                System.Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                System.Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }
    }
}
