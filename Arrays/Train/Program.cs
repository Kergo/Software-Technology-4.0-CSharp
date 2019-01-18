using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {           
           int[] wagons = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                total += wagons[i];
                System.Console.Write(wagons[i] + " ");
            }
            System.Console.WriteLine("");
           System.Console.WriteLine(total);
        }
    }
}
