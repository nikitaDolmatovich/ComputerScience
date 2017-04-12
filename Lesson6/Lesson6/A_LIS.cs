using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public static class A_LIS
    {
        public static int GetLengthOfLIS(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int[] max = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                max[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        max[i] = Math.Max(max[i], max[j] + 1);
                    }
                }
            }

            int result = 0;
            for (int i = 0; i < max.Length; i++)
            {
                if (max[i] > result)
                {
                    result = max[i];
                }
            }
            return result;
        }

        public static int GetSize(int[] array)
        {
            return GetLengthOfLIS(array);
        }
    }
}
