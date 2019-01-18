using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
   public class Program
    {
       public static void Main(string[] args)
        {
         InputReader();
         ArrayPrinter(arrayNums.Count, "all");   
        }
        public static List<int> arrayNums = new List<int>();

        public static void InputReader(){

            //end – stop taking input and print the final state of the array

            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                arrayNums.Add(int.Parse(numbers[i]));
            }

            string[] args = Console.ReadLine().Split(' ');

            while (args[0] != "end")
            {
                switch (args[0])
                {
                    case "exchange":
                        Exchange(int.Parse(args[1]));
                            break;
                    case "max":
                        MaxEvenOdd(args[1]);       
                            break;
                    case "min":
                        MinEvenOdd(args[1]);
                            break;
                    case "first":
                        FirstEvenOdd(int.Parse(args[1]), args[2]);
                            break;
                    case "last":
                        LastEvenOdd(int.Parse(args[1]), args[2]);
                            break;                
                    default:
                            break;
                }

                args = Console.ReadLine().Split(' ');
            }
        }

        public static void Exchange(int rotation)
        {
            //exchange {index} – splits the array after the given index,
            // and exchanges the places of the two resulting sub-arrays. 
            //E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
            if (rotation > arrayNums.Count)
            {
                System.Console.WriteLine("Invalid index");
                return;
            }

            List<int> temporary = new List<int>();

            for (int i = 0; i <= rotation; i++)
            {
                temporary.Add(arrayNums[i]);
            }

            arrayNums.RemoveRange(0, rotation + 1);
            arrayNums.AddRange(temporary);
        }

        public static void MaxEvenOdd(string args)
        {
            //max even/odd– returns the INDEX of the max even/odd element
            // -> [1, 4, 8, 2, 3] -> max odd -> print 4.
            //If there are two or more equal min/max elements,
            //return the index of the rightmost one.
            //If a min/max even/odd element cannot be found, print “No matches”
            int max = 0;
            int index = -1;

            if (args == "even")
            {
                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if (arrayNums[i] % 2 == 0)
                    {
                        if (arrayNums[i] >= max)
                        {
                            max = arrayNums[i];
                            index = i;
                        }
                    }
 
                }
            }
            else
            {
                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if (arrayNums[i] % 2 == 1)
                    {
                        if (arrayNums[i] >= max)
                        {
                            max = arrayNums[i];
                            index = i;
                        }
                    }
                }
            }
            if (index == -1)
            {
                System.Console.WriteLine("No matches");
            }
            else
            {
            System.Console.WriteLine(index);
            }
        }

        public static void MinEvenOdd(string args)
        {
            //min even/odd – returns the INDEX of the min even/odd element
            // -> [1, 4, 8, 2, 3] -> min even > print 3

            int min = 999999999;
            int index = -1;

            if (args == "even")
            {
                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if (arrayNums[i] % 2 == 0)
                    {
                        if (arrayNums[i] <= min)
                        {
                            min = arrayNums[i];
                            index = i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if (arrayNums[i] % 2 == 1)
                    {
                        if (arrayNums[i] <= min)
                        {
                            min = arrayNums[i];
                            index = i;
                        }
                    }
                }
            }
            if (index == -1)
            {
                System.Console.WriteLine("No matches");
            }
            else
            {
                System.Console.WriteLine(index);
            }
        }

           public static List<int> arrayToPrint = new List<int>();

        public static void FirstEvenOdd(int count, string odEv)
        {
            //first {count} even/odd– returns the first {count} elements
            // -> [1, 8, 2, 3] -> first 2 even -> print [8, 2]
            //If the count is greater than the array length, print “Invalid count”
            //If there are not enough elements to satisfy the count, print as many as you can.
            //If there are zero even/odd elements, print an empty array “[]”

            if (count > arrayNums.Count)
            {
                System.Console.WriteLine("Invalid count");
                return;
            }

            if (odEv == "even")
            {
                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if (arrayNums[i] % 2 == 0)
                    {
                        arrayToPrint.Add(arrayNums[i]);
                    }
                }

                ArrayPrinter(count);
                arrayToPrint.Clear();
            }
            else
            {
                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if (arrayNums[i] % 2 == 1)
                    {
                        arrayToPrint.Add(arrayNums[i]);
                    }
                }

                ArrayPrinter(count);
                arrayToPrint.Clear();
            }
        }

        public static void LastEvenOdd(int count, string odEv)
        {
            //last {count} even/odd – returns the last {count} elements
            // -> [1, 8, 2, 3] -> last 2 odd -> print [1, 3]

            if (odEv == "even")
            {
                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if (arrayNums[i] % 2 == 0)
                    {
                        arrayToPrint.Add(arrayNums[i]);
                    }
                }
                
                ArrayPrinter(count, "last");
                arrayToPrint.Clear();
            }
            else
            {
                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if (arrayNums[i] % 2 == 1)
                    {
                        arrayToPrint.Add(arrayNums[i]);
                    }
                }

                ArrayPrinter(count, "last");
                arrayToPrint.Clear();
            }
        }
        public static void ArrayPrinter(int count, string side = "first")
        {

            if(side == "all")
            {
                System.Console.Write("[");

                for (int i = 0; i < arrayNums.Count; i++)
                {
                    if(i < arrayNums.Count -1)
                    {
                    System.Console.Write($"{arrayNums[i]}, "); 
                    }
                    else
                    {
                        System.Console.Write($"{arrayNums[i]}");
                    }
                }
                System.Console.WriteLine("]");
            }
            else    
            {
            if (count > arrayNums.Count)
            {
                System.Console.WriteLine("Invalid count");
                return;
            }

            System.Console.Write("[");

            if(side  == "first")
            {
                if(arrayToPrint.Count >= count)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if(i < count -1)
                        {
                            System.Console.Write($"{arrayToPrint[i]}, "); 
                        }
                        else
                        {
                            System.Console.Write($"{arrayToPrint[i]}");
                        }
                    }
                }
                else if(count >= arrayToPrint.Count)
                {
                    for (int i = 0; i < arrayToPrint.Count; i++)
                    {
                        if(i < arrayToPrint.Count -1)
                        {
                            System.Console.Write($"{arrayToPrint[i]}, "); 
                        }
                        else
                        {
                            System.Console.Write($"{arrayToPrint[i]}");
                        }
                    }
                }
            }
            else if(side == "last")
            {
                if (arrayToPrint.Count >= count)
                {
                    for (int i = arrayToPrint.Count - count; i < arrayToPrint.Count; i++)
                    {
                        if(i < arrayToPrint.Count -1)
                        {
                        System.Console.Write($"{arrayToPrint[i]}, "); 
                        }
                        else
                        {
                            System.Console.Write($"{arrayToPrint[i]}");
                        }
                    }
                }
                else if (arrayToPrint.Count <= count)
                {
                    for (int i = 0; i < arrayToPrint.Count; i++)
                    {
                        if(i < arrayToPrint.Count -1)
                        {
                            System.Console.Write($"{arrayToPrint[i]}, "); 
                        }
                        else
                        {
                            System.Console.Write($"{arrayToPrint[i]}");
                        }
                    }   
                }
            }
            
            System.Console.WriteLine("]");
            }
        }
    }
}