using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public static class B_LIS
    {
        public static int GetLengthOfLongDivComSubSeq(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int[] maxLength = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                maxLength[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] % numbers[j] == 0 && maxLength[j] + 1 > maxLength[i])
                    {
                        maxLength[i] = maxLength[j] + 1;
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

            return result;
        }

        public static int GetSize(int[] array)
        {
            return GetLengthOfLongDivComSubSeq(array);
        }
    }
}
