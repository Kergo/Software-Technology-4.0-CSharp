using System;

namespace NxNMatrix
{
   public class Program
    {
       public static void Main(string[] args)
        {
            PrintMatrix(int.Parse(Console.ReadLine()));
        }

        public static void PrintMatrix(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    System.Console.Write(size + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
