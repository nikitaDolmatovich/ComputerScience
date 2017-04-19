using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First task");
            Console.WriteLine(A_EditDist.GetDistanceEdinting("ab", "ab"));
            Console.WriteLine(A_EditDist.GetDistanceEdinting("short", "ports"));

            Console.WriteLine("Second Task");
            Console.WriteLine(B_EditDist.GetDistanceEdinting("ab", "ab"));
            Console.WriteLine(B_EditDist.GetDistanceEdinting("short", "ports"));

            Console.WriteLine("Third Task");
            Console.WriteLine(C_EditDist.GetDistanceEdinting("ab", "ab"));
            Console.WriteLine(C_EditDist.GetDistanceEdinting("short", "ports"));
        }
    }
}
