using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                List<string> str = input.Split().ToList();
                Student student = new Student(str[0],str[1],str[2],str[3]);
                students.Add(student);
            }
            string town = Console.ReadLine();
            students = students.Where(x => x.HomeTown == town).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        public class Student
        {
            public Student(string firstName,string lastName,string age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
