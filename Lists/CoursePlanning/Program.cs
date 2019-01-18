using System;
using System.Linq;
using System.Collections.Generic;

namespace CoursePlanning
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] tokens = input.Split(":");
                string command = tokens[0];                

                switch (command)
                {
                    case "Add":
                        AddCourse(courses, tokens[1]);
                            break;
                    case "Insert":
                        InsertCourse(courses, tokens[1], int.Parse(tokens[2]));
                            break;
                    case "Remove":
                        RemoveCourse(courses, tokens[1]);
                            break;
                    case "Swap":
                        SwapCourses(courses, tokens[1], tokens[2]);
                            break;
                    case "Exercise":
                        Exercise(courses, tokens[1]);
                            break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < courses.Count; i++)
            {
                System.Console.WriteLine(i + 1 + "." + courses[i]);
            }
        }

        private static void AddCourse(List<string> courses, string lesson)
        {
            if (!courses.Contains(lesson))
            {
                courses.Add(lesson);
            }
        }
        
        private static void InsertCourse(List<string> courses, string lesson, int index)
        {
            if (!courses.Contains(lesson) && index == courses.Count)
            {
                courses.Add(lesson);
            }
            if (!courses.Contains(lesson) && index >= 0 && index < courses.Count)
            {
                courses.Insert(index, lesson);
            }
        }
        private static void RemoveCourse(List<string> courses, string lesson)
        {
            if (courses.Contains(lesson))
            {
                courses.Remove(lesson);
            }

            string exerciseTitle = lesson + "-Exercise";

            if (courses.Contains(exerciseTitle))
            {
                courses.Remove(exerciseTitle);
            }
        }

        private static void SwapCourses(List<string> courses, string firstL, string secondL)
        {
            if (courses.Contains(firstL) && courses.Contains(secondL))
            {
                int indexOfFirst = courses.IndexOf(firstL);
                int indexOfSecond = courses.IndexOf(secondL);
                string exTitleFirst = firstL + "-Exercise";
                string exTitleSecond = secondL + "-Exercise";

                courses[indexOfFirst] = secondL;
                courses[indexOfSecond] = firstL;

                if (courses.Contains(exTitleFirst))
                {
                    courses.RemoveAt(indexOfFirst + 1);
                    courses.Insert(indexOfSecond + 1, exTitleFirst);
                }
                if (courses.Contains(exTitleSecond))
                {
                    courses.RemoveAt(indexOfSecond + 1);
                    courses.Insert(indexOfFirst + 1, exTitleSecond);
                }
            }
        }

        private static void Exercise(List<string> courses, string lesson)
        {
            string exercise = lesson + "-Exercise";
            int index = courses.IndexOf(lesson);

            if (courses.Contains(lesson) && !courses.Contains(exercise))
            {
                courses.Insert(index + 1, exercise);               
            }
            else if(!courses.Contains(lesson) && !courses.Contains(exercise))
            {
                courses.Add(lesson);
                courses.Add(exercise);
            }
        }
    }
}