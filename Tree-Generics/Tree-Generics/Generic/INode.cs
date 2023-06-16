using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Generic
{
    public interface INode<TValue>
    {
        public TValue Value { get; set; }
        public INode<TValue> Parent { get; set; }
        public IReadOnlyCollection<INode<TValue>> Children { get; }
        public bool IsRoot();
        public bool IsLeaf();
        public void Add(in INode<TValue> node);
        public bool Remove(in INode<TValue> node);
        public  IEnumerable<INode<TValue>> GetAncestors();
        public IEnumerable<INode<TValue>> GetAncestorsAndSelf();
        public IEnumerable<INode<TValue>> GetDescendents();
        public IEnumerable<INode<TValue>> GetDescendentsAndSelf();
    }
}
