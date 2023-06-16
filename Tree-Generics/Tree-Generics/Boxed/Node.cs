using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Boxed
{
    public class Node : INode
    {
        public List<INode> m_Children = new List<INode>();
        public object Value  {get;}
        public INode Parent { get ; set ; }
        public Node(object value) => Value = value;
        public IReadOnlyCollection<INode> Children => m_Children;
        public override string ToString() => $"{Value}";
        public void Add(INode node)
        {
            node.Parent?.Remove(node); //node parent is not null
            node.Parent = this;
            m_Children.Add(node);
        }
        public bool Remove(INode node)
        {
            node.Parent = default;
            return m_Children.Remove(node);
        }
    }
}
