using System;
using System.Globalization;

namespace DayOfWeek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dateAsString = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);

            System.Console.WriteLine(date.DayOfWeek);
        }
    }
}
