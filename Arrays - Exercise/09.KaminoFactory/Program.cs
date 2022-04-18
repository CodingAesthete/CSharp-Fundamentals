using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currSeq = -1;
            int maxSum = -1;
            int maxSeq = -1;
            int sumAr = 0;
            string input;
            int[] sums = new int[num];
            int startIndex = 0;
            string[] allSeqs = new string[50];

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                currSeq++;
                allSeqs[currSeq] = input;
                int[] nums = input.Split(new string[] { "!", "!!" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int sumArr = nums.Sum();
                sums[currSeq] = sumArr;
                int sumOnes = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == 1 && nums[i + 1] == 1)
                    {
                        sumOnes++;
                        if (sumOnes==1)
                        {
                            sumOnes = 2;
                        }
                        if (sumOnes > maxSum)
                        {
                            maxSum = sumOnes;
                            maxSeq = currSeq;
                            startIndex = i - (sumOnes - 1);
                            sumAr = sumArr;
                        }
                        else if (sumOnes == maxSum)
                        {
                            if (i - (sumOnes - 1) < startIndex)
                            {
                                maxSum = sumOnes;
                                maxSeq = currSeq;
                                startIndex = i - (sumOnes - 1);
                                sumAr = sumArr;
                            }
                            else if (i - (sumOnes - 1) == startIndex)
                            {
                                if (sumArr > sums[currSeq])
                                {
                                    maxSum = sumOnes;
                                    maxSeq = currSeq;
                                    startIndex = i - (sumOnes - 1);
                                    sumAr = sumArr;
                                }
                            }
                        }
                    }
                    else if(nums[i]==1)
                    {
                        sumOnes = 1;
                        if (sumOnes > maxSum)
                        {
                            maxSum = sumOnes;
                            maxSeq = currSeq;
                            startIndex = i - (sumOnes - 1);
                            sumAr = sumArr;
                        }
                    }
                    else
                    {
                        sumOnes = 0;
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {maxSeq + 1} with sum: {sumAr}.");
            int[] maxSeqNums = allSeqs[maxSeq].Split(new string[] { "!", "!!"}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(String.Join(" ", maxSeqNums));
        }
    }
}
