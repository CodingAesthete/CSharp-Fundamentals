using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            int students = int.Parse(Console.ReadLine());
            for (int i = 0; i < students; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                Student student = new Student(input[0],input[1],double.Parse(input[2]));
                list.Add(student);
            }
            foreach (var item in list.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine(item.ToString());
            }
        }

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

            public override string ToString()
            {
                return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
            }
        }
    }
}
