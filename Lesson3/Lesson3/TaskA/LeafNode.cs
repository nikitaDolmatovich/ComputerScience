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
        private static Dictionary<char, string> codes = new Dictionary<char, string>(); 

        public LeafNode(char symbol, int frequency) : base(frequency)
        {
            this.symbol = symbol;
        }

        public override void FillCodes(string code)
        {
            codes.Add(this.symbol, code);
        }

        public static Dictionary<char,string> GetCodes()
        {
            return codes;
        }
    }
}
