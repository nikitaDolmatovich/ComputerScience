using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public static class CoutingSort
    {
        public static int[] Sort(int[] array)
        {
            int[] aux = new int[array.Length];
            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                else if (array[i] > max) max = array[i];
            }

            int[] counts = new int[max - min + 1];

            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - min]++;
            }

            counts[0]--;
            for (int i = 1; i < counts.Length; i++)            
            { 
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)               
            {
                aux[counts[array[i] - min]--] = array[i];
            }

            return aux;
        }
    }
}
