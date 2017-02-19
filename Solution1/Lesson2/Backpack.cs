using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Backpack
    {
        public Double CalculateTotalSum(Item[] items, Int32 weight, Int32 numberOfThings)
        {
            Double completeCost = 0;
            Double completeWeight = 0;

            Array.Sort(items);
            foreach (var item in items)
            {
                if (item.Weight + completeWeight <= weight)
                {
                    completeWeight += item.Weight;
                    completeCost += item.Cost;
                }
                else
                {
                    completeCost += (weight - completeWeight) * (item.Cost / item.Weight);
                    return completeCost;
                }
            }
            return completeCost;
        }
    }
}
