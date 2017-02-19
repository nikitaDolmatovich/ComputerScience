using System;

namespace Lesson2
{
    public struct Item : IComparable<Item>
    {
        public Int32 Cost { get; set; }
        public Int32 Weight { get; set; }

        public Item(Int32 cost, Int32 weight)
        {
            Cost = cost;
            Weight = weight;
        }

        public Int32 CompareTo(Item that)
        {
            Double currentCostDivWeight = this.Cost / this.Weight;
            Double compareCostDivWeight = that.Cost / that.Weight;

            if (currentCostDivWeight > compareCostDivWeight) return -1;
            else if (currentCostDivWeight == compareCostDivWeight) return 0;

            return 1;
        }
    }
}