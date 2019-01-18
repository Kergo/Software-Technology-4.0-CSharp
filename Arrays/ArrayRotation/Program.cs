using System;
using System.Linq;
namespace ArrayRotation
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int firstNum = numbers[0];
            for (int k = 1; k <= numbers.Length - 1; k++)
            {
                    numbers[k - 1] = numbers[k];
            }
                numbers[numbers.Length - 1] = firstNum;
            }            
            System.Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
