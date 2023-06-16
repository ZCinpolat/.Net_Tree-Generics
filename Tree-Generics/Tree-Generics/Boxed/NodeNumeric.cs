using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Boxed
{
    public class NodeNumeric : Node
    {
        public int UnBoxedValue => (int)Value;
        public NodeNumeric(int value) : base(value)
        {
        }
    }
}
