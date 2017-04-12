using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public static class C_LIS
    {
        public static int GetLengthOfLongNotUpSubSeq(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int[] maxLength = new int[numbers.Length];
            int[] previousIndex = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                maxLength[i] = 1;
                previousIndex[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] >= numbers[i] && maxLength[j] + 1 >= maxLength[i])
                    {
                        maxLength[i] = maxLength[j] + 1;
                        previousIndex[i] = j;
                    }
                }
            }

            int result = 0;
            for (int i = 0; i < maxLength.Length; i++)
            {
                if (maxLength[i] > result)
                {
                    result = maxLength[i];
                }
            }

            int[] numberOfNotUpSubSeq = new int[result];
            int k = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (maxLength[i] > maxLength[k])
                {
                    k = i;
                }
            }
            for (int j = result - 1; k >= 0; j--)
            {
                numberOfNotUpSubSeq[j] = k + 1;
                k = previousIndex[k];
            }

            return result;
        }

        public static int GetSIze(int[] array)
        {
            return GetLengthOfLongNotUpSubSeq(array);
        }
    }
}
