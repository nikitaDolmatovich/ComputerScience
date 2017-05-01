using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public static class Knapsack_A
    {
        public static int GetMaxWeight(int weight, int number, int[] gold)
        {
            return SolveKnapsackWithRepetitions(weight, number, gold);
        }

        private static int SolveKnapsackWithRepetitions(int weight, int number, int[] values)
        {
            int[] maxWeight = new int[weight];

            for (int i = 0; i < weight; i++)
            {
                maxWeight[i] = 0;
            }
            for (int i = 0; i < weight; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (values[j] <= i)
                    {
                        maxWeight[i] = Math.Max(maxWeight[i], maxWeight[i - values[j]] + values[j]);
                    }
                }
            }

            return maxWeight[weight - 1];
        }
    }
}
