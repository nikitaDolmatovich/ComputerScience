using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public static class Merge
    {
        public static IComparable[] Merge_Sort(IComparable[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return MergeArray(Merge_Sort(massive.Take(mid_point).ToArray()), Merge_Sort(massive.Skip(mid_point).ToArray()));
        }

        private static IComparable[] MergeArray(IComparable[] mass1, IComparable[] mass2)
        {
            int a = 0, b = 0;
            IComparable[] merged = new IComparable[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b.CompareTo(mass2.Length) < 0 && a.CompareTo(mass1.Length) < 0)
                    if (mass1[a].CompareTo(mass2[b]) > 0)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }
    }
}
