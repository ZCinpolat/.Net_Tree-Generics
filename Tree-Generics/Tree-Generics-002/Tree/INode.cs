using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics_002.Tree
{
    public interface INode<TNode>
        where TNode: class,INode<TNode>
    {
         TNode Parent { get; set; }
         IEnumerable<TNode> Children { get;  }
    }

    public interface INode<TNode,TValue> : 
        INode<TNode>
        where TNode : class, INode<TNode,TValue>
    {
       TValue Value { get; set; }
    }

}
