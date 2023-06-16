using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Boxed
{
    public class Node<TValue> : Node
    {
        public TValue UnboxedValue => (TValue)Value;
        public Node(TValue value) : base(value)
        {
        }
    }
}
