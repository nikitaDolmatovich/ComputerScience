using System;

namespace Lesson2
{
    public struct Event : IComparable<Event>
    {
        public Int32 Start { get; set; }
        public Int32 Finish { get; set; }

        public Event(Int32 start, Int32 finish)
        {
            Start = start;
            Finish = finish;
        }

        public Int32 CompareTo(Event that)
        {
            if (Finish > that.Finish) return 1;
            if (Finish == that.Finish) return 0;

            return -1;
        }

        public override string ToString()
        {
            return "("+ Start + ":" + Finish +")";
        }
    }
}