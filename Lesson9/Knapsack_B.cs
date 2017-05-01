using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public static class Knapsack_B
    {
        public static int GetMaxWeight(int weight, int number, int[] gold)
        {
            return SolveKnapsackWithoutRepetition(weight, number, gold);
        }

        public static int SolveKnapsackWithoutRepetition(int weight, int number, int[] values)
        {
            int[,] maxWeight = new int[weight + 1,number + 1];
            for (int i = 0; i < weight + 1; i++)
            {
                maxWeight[i,0] = 0;
            }
            for (int i = 0; i < number + 1; i++)
            {
                maxWeight[0,i] = 0;
            }

            for (int i = 1; i < number + 1; i++)
            {
                for (int w = 1; w < weight + 1; w++)
                {
                    maxWeight[w,i] = maxWeight[w,i - 1];
                    if (values[i - 1] <= w)
                    {
                        maxWeight[w,i] = Math.Max(maxWeight[w,i], maxWeight[w - values[i - 1],i - 1] + values[i - 1]);
                    }
                }
            }

            return maxWeight[weight,number];
        }

    }
}
