using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Boxed
{
    public class NodeText : Node
    {
        public string UnboxedValue => (string)Value;
        public NodeText(string value) : base(value)
        {
        }
    }
}
