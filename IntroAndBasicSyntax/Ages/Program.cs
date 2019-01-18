using System;

namespace Ages
{
   public class Program
    {
       public static void Main(string[] args)
        {
           int age = int.Parse(Console.ReadLine());

           if (age >= 0 && age <= 2)
           {
               System.Console.WriteLine("baby");
           }
           else if (age >= 3 && age <= 13)
           {
               System.Console.WriteLine("child");
           }
           else if (age >= 14 && age <= 19)
           {
               System.Console.WriteLine("teenager");
           }
            else if (age >= 20 && age <= 65)
            {
                System.Console.WriteLine("adult");
            }
            else if (age >= 66)
            {
                System.Console.WriteLine("elder");
            }
        }
    }
}
