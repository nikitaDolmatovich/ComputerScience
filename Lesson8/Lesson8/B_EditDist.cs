using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public static class B_EditDist
    {
        public static int GetDistanceEdinting(String one, String two)
        {
            int[,] levensteignDistances = new int [one.Length + 1, two.Length + 1];

            for (int i = 0; i < one.Length + 1; i++)
            {
                levensteignDistances[i, 0] = i;
            }

            for (int j = 0; j < two.Length + 1; j++)
            {
                levensteignDistances[0,j] = j;
            }

            for (int i = 0; i < one.Length; i++)
            {
                for (int j = 0; j < two.Length; j++)
                {
                    int cost = GetDiff(one[i], two[j]);
                    levensteignDistances[i + 1, j + 1] = Math.Min(Math.Min(levensteignDistances[i, j + 1] + 1,
                        levensteignDistances[i + 1,j] + 1), levensteignDistances[i,j] + cost);
                }
            }

            int result = levensteignDistances[one.Length, two.Length];

            return result;
        }

        private static int GetDiff(char one, char two)
        {
            return (one != two) ? 1 : 0;
        }
    }
}
