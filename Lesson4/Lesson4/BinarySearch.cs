using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public static class BinarySearch
    {
        public static int? BinarySearchs(int[] a, int x)
        {
            if ((a.Length == 0) || (x < a[0]) || (x > a[a.Length - 1]))
            {
                return null;
            }

            int first = 0;
      
            int last = a.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (x <= a[mid])
                    last = mid;
                else
                    first = mid + 1;
            }

            if (a[last] == x)
                return last;
            else
                return null;
        }
    }
}
