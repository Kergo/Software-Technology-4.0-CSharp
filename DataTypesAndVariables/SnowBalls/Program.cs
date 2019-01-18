using System;
using System.Numerics;

namespace SnowBalls
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int currentballSnow = int.Parse(Console.ReadLine());
                int currentballTime = int.Parse(Console.ReadLine());
                int currentballQuality = int.Parse(Console.ReadLine());
                BigInteger currentballValue = BigInteger.Pow((currentballSnow / currentballTime), currentballQuality);
                if (currentballValue > snowballValue)
                {
                    snowballValue = currentballValue;
                    snowballSnow = currentballSnow;
                    snowballTime = currentballTime;
                    snowballQuality = currentballQuality;
                }
            }

            System.Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
        }
    }
}
