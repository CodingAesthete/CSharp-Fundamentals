using System;

namespace _10.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokedPoks = 0;
            int power = n;

            while (n * 0.50m != power )
            {
                pokedPoks++;
                power -= m;
                if (power < m)
                {
                    break;
                }
            }

            if (power*2.0m==n && y>0)
            {
                    power /= y;
            }

            while (power>= m)
            {
                pokedPoks++;
                power -= m;
                if (power < m)
                {
                    break;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(pokedPoks);
        }
    }
}