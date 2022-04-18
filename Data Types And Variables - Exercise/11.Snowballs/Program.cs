using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snow/ time), quality);

                if (value>maxValue)
                {
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                    maxValue = value;
                }
            }

            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
