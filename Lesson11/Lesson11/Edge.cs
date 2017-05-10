using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Edge
    {
        int from;
        int to;
        int weight;

        public Edge(int u, int v, int w)
        {
            this.from = u;
            this.to = v;
            this.weight = w;
        }

        public int GetFrom()
        {
            return from;
        }

        public void SetFrom(int from)
        {
            this.from = from;
        }

        public int GetTo()
        {
            return to;
        }

        public void SetTo(int to)
        {
            this.to = to;
        }

        public int GetWeight()
        {
            return weight;
        }

        public void SetWeight(int weight)
        {
            this.weight = weight;
        }

    }
}
