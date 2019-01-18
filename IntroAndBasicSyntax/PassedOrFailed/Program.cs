using System;

namespace PassedOrFailed
{
   public class Program
    {
        public static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if(grade >= 3.00)
            {
                System.Console.WriteLine("Passed!");
            }
            else
            {
                System.Console.WriteLine("Failed!");
            }
        }
    }
}
