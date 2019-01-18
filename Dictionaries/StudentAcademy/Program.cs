using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputCount; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }

                students[name].Add(grade);
            }

            var average = students
                .Select(x => x)
                .Where(w => w.Value
                .Average() >= 4.5)
                .ToList();

            //PRINT STUDENTS AND AVERAGE GRADE -- ORDERED BY AVERAGE 

                
            System.Console.WriteLine();
        }
    }
}
