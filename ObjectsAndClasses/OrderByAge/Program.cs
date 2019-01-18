using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var people = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                
                var tockens = input.Split();
                var name = tockens[0];
                var id = tockens[1];
                var age = int.Parse(tockens[2]);
                var person = new Person(name, id, age);
                people.Add(person);
            }
            
            foreach (var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}