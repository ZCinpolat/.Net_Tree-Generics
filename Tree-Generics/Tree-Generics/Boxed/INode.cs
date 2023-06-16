using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Boxed
{
    public interface INode
    {
        object Value { get; }
        INode Parent { get; set; }
        IReadOnlyCollection<INode> Children { get; }
        void Add(INode node);
        bool Remove(INode node);

    }
}
