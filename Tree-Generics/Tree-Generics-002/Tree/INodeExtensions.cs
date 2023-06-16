

namespace Tree_Generics_002.Tree
{
    public static  class INodeExtensions
    {
        public static bool IsRoot<TNode>(this TNode node)
            where TNode : class, INode<TNode>
        {
            return node.Parent is null;
        }
        public static bool IsLeaf<TNode>(this TNode node)
            where TNode : class ,INode<TNode>
        {
            return !node.Children.Any();
        }

        public static IEnumerable<TNode> GetAncestors<TNode>(this TNode node)
           where TNode : class, INode<TNode>
        {
            while (!node.IsRoot())
            {
                yield return node;  
            }
        }

        public static IEnumerable<TNode> GetAncestorsAndSelf<TNode>(this TNode node)
             where TNode : class, INode<TNode>
        {
            return node.Concat(node.GetAncestors());
        }

        public static IEnumerable<TNode> GetDescendants<TNode>(this TNode node)
          where TNode : class, INode<TNode>
        {
           return node.Children.SelectMany(x => x.GetDescendantsAndSelf());
        }

        public static IEnumerable<TNode> GetDescendantsAndSelf<TNode>(this TNode node)
         where TNode : class, INode<TNode>
        {
            return node.Concat(node.GetDescendants());
        }

    }
}
