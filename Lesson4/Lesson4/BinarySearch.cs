using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public static class BinarySearch
    {
        public static int? BinarySearchs(int[] array, int index)
        {
            if ((array.Length == 0) || (index < array[0]) || (index > array[array.Length - 1]))
            {
                return null;
            }

            int first = 0;
      
            int last = array.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (index <= array[mid])
                    last = mid;
                else
                    first = mid + 1;
            }

            if (array[last] == index)
                return last;
            else
                return null;
        }
    }
}
