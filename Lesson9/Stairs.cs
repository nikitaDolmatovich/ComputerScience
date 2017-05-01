using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public static class Stairs
    {
        public static int GetMaxSum(int number, int[] values)
        {
            return CountMaxSumClimbingStairs(number, values);
        }

        private static int CountMaxSumClimbingStairs(int number, int[] values)
        {
            int[] maxSum = new int[number + 1];
            for (int i = 0; i < number + 1; i++)
            {
                maxSum[i] = 0;
            }
            for (int i = 1; i < number + 1; i++)
            {
                maxSum[i] = Math.Max(maxSum[i], maxSum[i - values[i - 1]] + values[i - 1]);
            }

            return maxSum[number];
        }
    }
}
