using System;
using System.Linq;

namespace Practice_HackerrankChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 10, 24, 14, 4, 25, 2, 26 };
            Console.WriteLine(string.Join(" ", breakingRecords(scores)));

        }
            static int[] breakingRecords(int[] scores)
            {
                int[] result = new int[2];

                int countMax = 0, countMin = 0, max = scores[0], min = scores[0];
                for (int i = 1; i < scores.Length; i++)
                {
                    if (scores[i] > max) { max = scores[i]; countMax++; }
                    else if (scores[i] < min) { min = scores[i]; countMin++; }
                }
                result[0] = countMax; result[1] = countMin;
            
                return result;
            }
        }
    }

