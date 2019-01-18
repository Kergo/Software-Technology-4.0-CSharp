using System;

namespace PadawanEquipment
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabers = Math.Ceiling(students + (students * 0.10));
            int freeBelts = students / 6;

            double totalPrice = (lightsabersPrice * lightsabers) + (robePrice * students) +
            ((students - freeBelts) * beltPrice);

            if(cash >= totalPrice)
            {
                System.Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                System.Console.WriteLine("Ivan Cho will need {0:f2}lv more.", (totalPrice - cash));
            }
        }
    }
}
