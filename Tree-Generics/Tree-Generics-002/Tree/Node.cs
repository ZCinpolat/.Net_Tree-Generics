using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics_002.Tree
{
    public abstract class Node<TNode, TValue> : INode<TNode, TValue>
        where TNode : class,INode<TNode,TValue>
    {

        public TNode Parent { get; set; }
        public abstract IEnumerable<TNode> Children { get;  }    
        public TValue Value { get; set; }
 

        protected Node(TValue value) => Value = value;
        public override string ToString() => $"{Value}";

    }
}
