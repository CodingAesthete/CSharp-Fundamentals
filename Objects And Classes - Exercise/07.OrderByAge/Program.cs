using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] line = command.Split();
                string name = line[0];
                string id = line[1];
                int age = int.Parse(line[2]);
                Person person = new Person();
                person.Name = name;
                person.ID = id;
                person.Age = age;
                catalogue.add.Add(person);
            }
            foreach (var item in catalogue.add.OrderBy(s => s.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }
        public class Catalogue
        {
            public List<Person> add { get; set; }
            public Catalogue()
            {
                add = new List<Person>();
            }
        }
    }
}
