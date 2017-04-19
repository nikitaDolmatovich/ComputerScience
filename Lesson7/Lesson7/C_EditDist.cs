using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public static class C_EditDist
    {
        public static string GetDistanceEdinting(String one, String two)
        {
            int[,] levensteignDistances = new int[one.Length + 1, two.Length + 1];

            for (int i = 0; i < one.Length + 1; i++)
            {
                levensteignDistances[i, 0] = i;
            }

            for (int j = 0; j < two.Length + 1; j++)
            {
                levensteignDistances[0, j] = j;
            }

            for (int i = 0; i < one.Length; i++)
            {
                for (int j = 0; j < two.Length; j++)
                {
                    int cost = GetDiff(one[i], two[j]);
                    levensteignDistances[i + 1, j + 1] = Math.Min(Math.Min(levensteignDistances[i, j + 1] + 1,
                        levensteignDistances[i + 1, j] + 1), levensteignDistances[i, j] + cost);
                }
            }

            return FormSequenceChanges(levensteignDistances, one, two);
        }

        private static String FormSequenceChanges(int[,] levensteignDistances, String one, String two)
        {

            StringBuilder result = new StringBuilder();

            int a = one.Length;
            int b = two.Length;

            while (a > 0)
            {
                while (b > 0)
                {

                    int needToBeInsert = levensteignDistances[a, b - 1];
                    int needToBeDelete = levensteignDistances[a - 1, b];
                    int needToBeReplace = levensteignDistances[a - 1, b - 1];
                    int minimum = Math.Min(Math.Min(needToBeDelete, needToBeInsert), needToBeReplace);

                    if (minimum == needToBeReplace)
                    {
                        int cost = GetDiff(one[a-- - 1], two[b-- - 1]);
                        if (cost == 0)
                        {
                            result.Append("#,");
                        }
                        if (cost == 1)
                        {
                            result.Append("~" + two[b] + ",");
                        }
                    }
                    if (minimum == needToBeDelete)
                    {
                        result.Append("-" + one[--a] + ",");
                    }
                    if (minimum == needToBeInsert)
                    {
                        result.Append("+" + two[--b] + ",");
                    }
                }
            }
            return result.ToString();

        }

        private static int GetDiff(char one, char two)
        {
            return (one != two) ? 1 : 0;
        }
    }
}
