using System;
using System.Linq;
namespace TopIntegers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] <= numbers[k])
                    {
                        break;
                    }
                    else if (k == numbers.Length -1)
                    {
                        System.Console.Write(numbers[i]+ " ");
                    }
                }
            }
            System.Console.WriteLine(numbers[numbers.Length -1]);
        }
    }
}