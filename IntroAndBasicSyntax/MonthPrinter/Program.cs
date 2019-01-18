using System;

namespace MonthPrinter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    System.Console.WriteLine("January");
                        break;
                case 2:
                    System.Console.WriteLine("February");
                        break;
                case 3:
                    System.Console.WriteLine("March");
                        break;
                case 4:
                    System.Console.WriteLine("April");
                        break;
                case 5:
                    System.Console.WriteLine("May");
                        break;
                case 6:
                    System.Console.WriteLine("June");
                        break;
                case 7:
                    System.Console.WriteLine("July");
                        break;
                case 8:
                    System.Console.WriteLine("August");
                        break;
                case 9:
                    System.Console.WriteLine("September");
                        break;
                case 10:
                    System.Console.WriteLine("October");
                        break;
                case 11:
                    System.Console.WriteLine("November");
                        break;
                case 12:
                    System.Console.WriteLine("December");
                        break;
                default:
                    System.Console.WriteLine("Error!");
                        break;
            }
        }
    }
}
