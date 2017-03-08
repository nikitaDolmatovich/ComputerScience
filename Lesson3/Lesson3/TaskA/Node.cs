using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.TaskA
{
    public abstract class Node : IComparable<Node>
    {
        public int Frequency { get; set; }

        public Node(int frequency)
        {
            Frequency = frequency;
        }

        public abstract void FillCodes(string code);

        public int CompareTo(Node node)
        {
            if (Frequency > node.Frequency) return 1;
            else if (Frequency == node.Frequency) return 0;

            return -1;
        }
    }
}
