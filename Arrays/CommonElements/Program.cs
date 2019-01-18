using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            foreach (var item in first)
            {
                foreach (var itemtwo in second)
                {
                    if (itemtwo == item)
                    {
                        System.Console.Write(itemtwo + " ");
                    }
                }
            }

        }
    }
}
