using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.TaskA
{
    public class InternalNode : Node
    {
        private Node left;
        private Node right;

        public InternalNode(Node left, Node right) : base(left.Frequency + right.Frequency)
        {
            this.left = left;
            this.right = right;
        }

        public override void FillCodes(string code)
        {
            left.FillCodes(code + "0");
            right.FillCodes(code + "1");
        }
    }
}
