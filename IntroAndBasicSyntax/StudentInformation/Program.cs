using System;

namespace StudentInformation
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
