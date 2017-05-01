using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First task");
            int weight_a = Knapsack_A.GetMaxWeight(15, 3, new int[] { 2,8,6});
            Console.WriteLine("Weight of gold = {0}", weight_a);

            Console.WriteLine("Second task");
            int weight_b = Knapsack_B.GetMaxWeight(10, 3, new int[] { 1, 4, 8 });
            Console.WriteLine("Weight of gold = {0}", weight_b);
        }
    }
}
