using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tockens = input.Split(" : ");
                string course = tockens[0];
                string name = tockens[1];

                if(!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(name);

                input = Console.ReadLine();
            }

            foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            {
                System.Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                kvp.Value
                    .OrderBy(w => w)
                    .ToList()
                    .ForEach(x => Console.WriteLine("-- " + x));
            }
        }
    }
}
