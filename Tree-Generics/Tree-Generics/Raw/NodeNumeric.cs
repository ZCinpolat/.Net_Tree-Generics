using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tree_Generics.Raw
{
    public class NodeNumeric
    {
        private readonly List<NodeNumeric> m_Children = new List<NodeNumeric>();
        public int Value { get; }
        public NodeNumeric Parent { get; private set; }
        public IReadOnlyCollection<NodeNumeric> Children => m_Children;
        public NodeNumeric(int value) => Value = value;
        public override string ToString() => $"{Value}";
        public void Add(NodeNumeric node)
        {
            node.Parent?.Remove(node); //node parent is not null
            node.Parent = this;
            m_Children.Add(node);
        }
        public bool Remove(NodeNumeric node)
        {
            node.Parent = default;
            return m_Children.Remove(node);
        }


    }
}
