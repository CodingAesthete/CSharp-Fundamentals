namespace _02.OldestFamilyMember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Family family = new Family();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                int age = int.Parse(command[1]);
                Person person = new Person();
                person.Name = name;
                person.Age = age;
                family.added.Add(person);

            }
            string namee = family.GetOldestMember().Name;
            int agee = family.GetOldestMember().Age;
            Console.WriteLine($"{namee} {agee}");
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class Family
        {
            public List<Person> added { get; set; }
            public Family()
            {
                added = new List<Person>();
            }
            public Person GetOldestMember()
            {
                var Student = added.OrderByDescending(s => s.Age).First();
                return Student;
            }
        }
    }
}
