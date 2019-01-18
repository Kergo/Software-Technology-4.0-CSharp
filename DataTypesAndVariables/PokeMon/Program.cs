using System;

namespace PokeMon
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int originalPower = power;

            int pokedTargets = 0;

            while (power > distance)
            {
                power = power - distance;
                if (originalPower == power * 2)
                {
                    if (power >= exhaustionFactor)
                    {
                        power = power / exhaustionFactor;                    
                    }
                }
                pokedTargets ++;
            }
            System.Console.WriteLine(power);
            System.Console.WriteLine(pokedTargets);
        }
    }
}
