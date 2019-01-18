using System;

namespace AddAndSubtract
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sumResult = SumOfTwoNums(firstNum, secondNum);
            int finalResult = SubtractOfTwoNums(sumResult, thirdNum);
            System.Console.WriteLine(finalResult);
        }

        public static int SumOfTwoNums(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public static int SubtractOfTwoNums(int firstNum, int secondNum)
        {
           return firstNum - secondNum;
        }
    }
}
