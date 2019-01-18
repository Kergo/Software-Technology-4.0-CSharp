using System;

namespace VendingMachine
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double amount = 0.0;
            string input = Console.ReadLine();
            while (input != "Start")
            {
                double coint = double.Parse(input);  
                if (coint == 0.1 || coint == 0.2 || coint == 0.5 || coint == 1 || coint == 2)
                {
                    amount += coint;
                }
                else
                {
                    System.Console.WriteLine($"Cannot accept {coint}");
                }
                 input = Console.ReadLine();
            } 
            do
            {
                double price = 0.0;
                input = Console.ReadLine();
                switch (input)
                {
                    case "Nuts":
                        price = 2.0;
                            break;
                    case "Water":
                        price = 0.7;
                            break;
                    case "Crisps":
                        price = 1.5;
                            break;
                    case "Soda":
                        price = 0.8;
                            break;
                    case "Coke":
                        price = 1.0;
                            break;                                
                    default:
                    price = 0;
                            break;
                }
                if(price == 0 && input != "End")
                {
                        System.Console.WriteLine("Invalid product");
                }
                else if (amount >= price && price != 0)
                {
                    System.Console.WriteLine($"Purchased {input.ToLower()}");
                    amount -= price;
                }
                else if (price > amount)
                {
                    System.Console.WriteLine("Sorry, not enough money");
                }
            } while(input != "End");

                    System.Console.WriteLine($"Change: {amount:f2}");
        }
    }
}
