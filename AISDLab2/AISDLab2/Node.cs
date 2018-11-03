using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISDLab2
{
    public class Node
    {
        public string Char { get; set; }
        public int Key { get; set; }
        public int Ch { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }


        public Node(string Char, int Key)
        {
            this.Char = Char;
            this.Key = Key;
        }
    }
}
