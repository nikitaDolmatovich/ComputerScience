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
            int weight = Knapsack_A.GetMaxWeight(15, 3, new int[] { 2,8,6});
            Console.WriteLine("Weight of gold = {0}", weight);
        }
    }
}
