﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Raw
{
    public class NodeText
    {
        private readonly List<NodeText> m_Children = new List<NodeText>();
        public string Value { get; }
        public NodeText Parent { get; private set; }
        public IReadOnlyCollection<NodeText> Children => m_Children;
        public NodeText(string value) => Value = value;
        public override string ToString() => $"{Value}";
        public void Add(NodeText node)
        {
            node.Parent?.Remove(node); //node parent is not null
            node.Parent = this;
            m_Children.Add(node);
        }
        public bool Remove(NodeText node)
        {
            node.Parent = default;
            return m_Children.Remove(node);
        }
    }
}
