
namespace Tree_Generics_002.Tree
{
  
        public interface IBelongToNode<out TNode>
            where TNode : class, INode<TNode>
        {
            public TNode Node { get;  }
          
        }

        public interface IBelongToNode<TNode, TValue> :
            IBelongToNode<TNode>
            where TNode : class, INode<TNode, TValue>
        {
           
        }
}
