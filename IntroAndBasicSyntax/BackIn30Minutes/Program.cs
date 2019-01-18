using System;

namespace BackIn30Minutes
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            DateTime afterThirtyMin = new DateTime(1, 2, 3, hours, minutes, 0);

            afterThirtyMin = afterThirtyMin.AddMinutes(30);

            System.Console.WriteLine($"{afterThirtyMin.Hour}:{afterThirtyMin.Minute:d2}");
        }
    }
}
