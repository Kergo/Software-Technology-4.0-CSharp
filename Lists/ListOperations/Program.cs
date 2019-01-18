using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

            string argsInput = Console.ReadLine();

            while (argsInput != "End")
            {
                string operation = "";
                int value = 0;
                string arg = "";
                
                if (argsInput.Split().Length == 2)
                {
                    operation = argsInput.Split()[0];
                    value = int.Parse(argsInput.Split()[1]);
                }
                else
                {
                    operation = argsInput.Split()[0];
                    arg = argsInput.Split()[1];
                    value = int.Parse(argsInput.Split()[2]);
                }
                if (operation == "Add")
                {
                    list.Add(value);                    
                }
                else if (operation == "Insert")
                {
                    if (list.Count >= value)
                    {
                    list.Insert(value, int.Parse(arg));
                    }                    
                }
                else if (operation == "Remove")
                {
                    if(value <= list.Count)
                    {
                    list.RemoveAt(value);                           
                    }
                    else
                    {
                    System.Console.WriteLine("Invalid index");
                    }
                }
                else
                {
                   if (arg == "left")
                        {
                            for (int i = 0; i < value; i++)
                            {
                                int first = list.First();
                                list.Add(first);
                                list.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < value; i++)
                            {
                                int last = list.Last();
                                list.Insert(0, last);
                                list.RemoveAt(list.Count - 1);
                            }
                        } 
                }

                argsInput = Console.ReadLine();
            }

            System.Console.WriteLine(string.Join(' ', list));
        }
    }
}
