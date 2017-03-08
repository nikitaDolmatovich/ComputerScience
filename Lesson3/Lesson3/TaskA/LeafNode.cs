using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.TaskA
{
    public class LeafNode : Node
    {
        private char symbol;
        private HoffmanA hoff = new HoffmanA();

        public LeafNode(char symbol, int frequency) : base(frequency)
        {
            this.symbol = symbol;
        }

        public override void FillCodes(string code)
        {
            hoff.Codes.Add(this.symbol, code);
        }
    }
}
