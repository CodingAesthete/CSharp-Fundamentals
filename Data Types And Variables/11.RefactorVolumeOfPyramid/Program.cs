using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, heigth;
            length = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
            heigth = double.Parse(Console.ReadLine());

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");

            double volume = (length * width * heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
