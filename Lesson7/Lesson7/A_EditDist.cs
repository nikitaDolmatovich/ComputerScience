using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public static class A_EditDist
    {
        private static int GetDistance(String one, String two, int i, int j)
        {

            if (i == 0)
            {
                return j;
            }
            if (j == 0)
            {
                return i;
            }

            if (one[i - 1] == two[j - 1])
            {
                return GetDistance(one, two, i - 1, j - 1);
            }

            int delete = GetDistance(one, two, i - 1, j) + 1;
            int insert = GetDistance(one, two, i, j - 1) + 1;
            int replace = GetDistance(one, two, i - 1, j - 1) + 1;

            return Math.Min(Math.Min(insert, replace), delete);
        }

        public static int GetDistanceEdinting(String one, String two)
        {
            return GetDistance(one, two, one.Length, two.Length);
        }
    }
}
