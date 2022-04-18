using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int nume = num;
            string number = ""+num;
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int curr=nume  % 10;
                nume /= 10;
                int currFact = 1;

                for (int e = 1; e <=curr ; e++)
                {
                    currFact *= e;
                }
                sum += currFact;
            }

            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
