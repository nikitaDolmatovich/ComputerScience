using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public static class QSortOptimezed
    {
        public static void binarySearch(int[] result, Segment[] segments, int[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                int leftIndex = 0;
                int rightIndex = segments.Length - 1;
                while (leftIndex <= rightIndex)
                {
                    int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                    if (segments[middleIndex].Start <= points[i] && segments[middleIndex].Stop >= points[i])
                    {
                        result[i]++;
                        for (int j = middleIndex - 1; j >= leftIndex; j--)
                        {
                            if (segments[j].Start <= points[i] && segments[j].Stop >= points[i])
                            {
                                result[i]++;
                            }
                        }
                        for (int j = middleIndex + 1; j <= rightIndex; j++)
                        {
                            if (segments[j].Start <= points[i] && segments[j].Stop >= points[i])
                            {
                                result[i]++;
                            }
                        }
                        break;
                    }
                    else
                    {
                        if (segments[middleIndex].Start < points[i])
                        {
                            rightIndex = middleIndex - 1;
                        }
                        else
                        {
                            leftIndex = middleIndex + 1;
                        }
                    }
                }
            }
        }

        public static int[] GetAccessors(int numberSegment, int numberPoints)
        {
            Segment[] segment = new Segment[numberSegment];
            int[] point = new int[numberPoints];
            int[] result = new int[numberPoints];

            for (int i = 0; i < numberSegment; i++)
            {
                segment[i] = new Segment(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }

            Array.Sort(segment);

            for (int i = 0; i < segment.Length; i++)
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

            Array.Sort(segment);
            binarySearch(result, segment, point);
            return result;
        }
    }
}
