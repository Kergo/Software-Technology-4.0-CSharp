using System;
using System.Linq;
using System.Collections.Generic;

namespace Students2._0
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tockens = input.Split();
                string firstName = tockens[0];
                string lastName = tockens[1];
                int age = int.Parse(tockens[2]);
                string city = tockens[3];

                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (student == null)
                {
                    students.Add(new Student(firstName, lastName, age, city));
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }

                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            students
                .Where(s => s.City == filterCity)
                .ToList()
                .ForEach(s => System.Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old."));
        }
    }
}