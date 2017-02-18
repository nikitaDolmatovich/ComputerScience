using System;

namespace Lesson2
{
    struct Event
    {
        Int32 start;
        Int32 finish;

        public Event(Int32 start, Int32 finish)
        {
            this.start = start;
            this.finish = finish;
        }
    }
}