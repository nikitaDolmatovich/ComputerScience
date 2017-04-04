using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public static class QSort
    {
        public static int[] GetAccessors(int[] array, int numberSegment, int numberPoints)
        {
            Segment[] segment = new Segment[numberSegment];
            int[] point = new int[numberPoints];
            int[] result = new int[numberPoints];

            for(int i = 0; i < numberSegment; i++)
            {
                segment[i] = new Segment(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }

            Array.Sort(segment);

            for(int i = 0; i < segment.Length; i++)
            {
                Console.WriteLine(segment[i].Start + "," + segment[i].Stop);
            }

            for (int i = 0; i < numberPoints; i++)
            {
                point[i] = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < segment.Length; j++)
                {
                    if (segment[j].Stop >= point[i] && segment[j].Start <= point[i]) result[i]++;
                    if (segment[j].Stop < point[i]) break;
                }
            }

            return result;
        }
    }
}
