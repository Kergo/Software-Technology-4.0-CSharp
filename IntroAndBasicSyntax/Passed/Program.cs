using System;

namespace Passed
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
        }
    }
}
