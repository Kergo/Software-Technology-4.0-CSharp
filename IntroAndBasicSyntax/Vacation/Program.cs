using System;

namespace Vacation
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;
            double totalPrice = 0.0;

            if (groupType == "Students")
            {
                 switch (day)
            {
                case "Friday":
                    price = 8.45;
                        break;
                case "Saturday":
                    price = 9.80;
                        break;
                case "Sunday":
                    price = 10.46;
                        break;
                default:
                        break;
            }
                if (persons >= 30)
                {
                    price = price * 0.85;
                }
            }
            else if (groupType == "Business")
            {
                 switch (day)
            {
                case "Friday":
                    price = 10.90;
                        break;
                case "Saturday":
                    price = 15.60;
                        break;
                case "Sunday":
                    price = 16.00;
                        break;
                default:
                        break;
            }
                if (persons >= 100)
                {
                    persons -= 10;
                }
            }
            else if(groupType == "Regular")
            {
                 switch (day)
            {
                case "Friday":
                    price = 15.00;
                        break;
                case "Saturday":
                    price = 20.00;
                        break;
                case "Sunday":
                    price = 22.50;
                        break;
                default:
                        break;
            }
                if (persons >= 10 && persons <= 20)
                {
                    price = price * 0.95;
                }
            }
            totalPrice = persons * price;
            System.Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
