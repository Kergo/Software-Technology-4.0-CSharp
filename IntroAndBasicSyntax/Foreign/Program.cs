using System;

namespace Foreign
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA":
                    System.Console.WriteLine("English");
                        break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    System.Console.WriteLine("Spanish");
                        break;
                default:
                    System.Console.WriteLine("unknown");
                        break;
            }
        }
    }
}
