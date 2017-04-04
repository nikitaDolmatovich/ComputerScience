using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public struct Segment : IComparable<Segment>
    {
        public int Start { get; set; }
        public int Stop { get; set; }

        public Segment(int start, int stop)
        {
            this.Start = start;
            this.Stop = stop;
        }

        public int CompareTo(Segment that)
        {
            if (Stop > that.Stop) return 1;
            else if (Stop < that.Stop) return -1;
            return 0;
        }
    }
}
