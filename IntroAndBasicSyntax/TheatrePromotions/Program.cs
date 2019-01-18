using System;

namespace TheatrePromotions
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            
            if (age >= 0 && age <= 18)
            {
                switch (day)
                {
                    case "Weekday":
                        System.Console.WriteLine("12$");
                            break;
                    case "Weekend":
                        System.Console.WriteLine("15$");
                            break;
                    case "Holiday":
                        System.Console.WriteLine("5$");
                            break;                
                    default:
                            break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (day)
                {
                    case "Weekday":
                        System.Console.WriteLine("18$");
                            break;
                    case "Weekend":
                        System.Console.WriteLine("20$");
                            break;
                    case "Holiday":
                        System.Console.WriteLine("12$");
                            break;                
                    default:
                            break;
                }   
            }
            else if (age > 64 && age <= 122)
            {
                switch (day)
                {
                    case "Weekday":
                        System.Console.WriteLine("12$");
                            break;
                    case "Weekend":
                        System.Console.WriteLine("15$");
                            break;
                    case "Holiday":
                        System.Console.WriteLine("10$");
                            break;                
                    default:
                            break;
                }   
            }
            else
            {
                System.Console.WriteLine("Error!");
            }
        }
    }
}
