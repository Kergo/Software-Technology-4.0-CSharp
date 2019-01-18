using System;
using System.Collections.Generic;
using System.Linq;

namespace Students3
{
    public class Program
    {
        public class Student
        {
            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

           // public override string ToString()
           // {
            //    return $"{FirstName} {LastName}: {Grade:f2}";
            //}
        }
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                var student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students
               .OrderByDescending(g => g.Grade)
                .ToList()
                .ForEach(s => System.Console.WriteLine($"{s.FirstName} {s.LastName}: {s.Grade:f2}"));
        }
    }
}