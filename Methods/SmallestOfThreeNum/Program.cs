using System;

namespace SmallestOfThreeNum
{
   public class Program
    {
       public static void Main(string[] args)
        {  
            PrintSmallestOfThreeNums(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        public static void PrintSmallestOfThreeNums(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum < secondNum && firstNum < thirdNum)
            {
                System.Console.WriteLine(firstNum);
            }
            else if (secondNum < firstNum && secondNum < thirdNum)
            {
                System.Console.WriteLine(secondNum);
            }
            else
            {
                System.Console.WriteLine(thirdNum);
            }
        }
    }
}
