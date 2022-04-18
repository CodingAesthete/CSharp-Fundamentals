using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int peoplesPerCourse = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(people * 1.0 / peoplesPerCourse);
            Console.WriteLine(courses);
        }
    }
}
