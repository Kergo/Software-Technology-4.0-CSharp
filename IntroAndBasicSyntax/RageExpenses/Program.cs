using System;

namespace RageExpenses
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = lostGames / 2;
            int trashedMouses = lostGames / 3;
            int trashedKeyboards = lostGames / 6;
            int trashedDisplays = lostGames / 12;

            double expenses = (headsetPrice * trashedHeadsets) + (mousePrice * trashedMouses) +
                            (keyboardPrice * trashedKeyboards) + (displayPrice * trashedDisplays);

            System.Console.WriteLine($"Rage expenses: {expenses:f2} lv.");                

        }
    }
}
