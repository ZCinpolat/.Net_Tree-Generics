using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Generic
{
    public class Node<TValue> : 
        INode<TValue>
    {
        public readonly List<INode<TValue>> m_Children = new List<INode<TValue>>();
        public TValue Value { get; set; }
        public INode<TValue> Parent { get ; set; }
        public IReadOnlyCollection<INode<TValue>> Children => m_Children;
        public Node(TValue value) => Value = value;

        public override string ToString() => $"{Value}";

        public bool IsRoot() => Parent is null;
        public bool IsLeaf() => !m_Children.Any();

        public void Add(in INode<TValue> node)
        {
            node.Parent?.Remove(node);
            node.Parent = this;
            m_Children.Add(node);
        }
        public bool Remove(in INode<TValue> node)
        {
            node.Parent = default;
            return m_Children.Remove(node);
        }

       public IEnumerable<INode<TValue>> GetAncestors() // Noda ait olan childlarin hepsini listeler.
        {
            var node = (INode<TValue>)(this);
            while (!node.IsRoot())
            {
                node = node.Parent;
                yield return node;
            }
        }

        // note ait olan childalarin hepsini hepndisi ile birlikte listeler
        public IEnumerable<INode<TValue>> GetAncestorsAndSelf() => this.Concat(GetAncestors());
        //{
        //    return this.Concat(GetAncestors()); // With extensions
        //    //return new INode<TValue>[] { this }.Concat(GetAncestors()); // For parent will be first item
        //    //return GetAncestors().Append(this); // paret will be last item
        //    //yield return this;
        //    //foreach (var ancestor in GetAncestors())
        //    //{
        //    //    yield return ancestor;
        //    //}
        //}

        public IEnumerable<INode<TValue>> GetDescendents() => Children.SelectMany(child => child.GetDescendentsAndSelf());

        public IEnumerable<INode<TValue>> GetDescendentsAndSelf() => this.Concat(GetDescendents());
    
    }
}
