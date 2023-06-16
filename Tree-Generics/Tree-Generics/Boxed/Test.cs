using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tree_Generics.Raw;

namespace Tree_Generics.Boxed
{
    public static class Test
    {
        public static void Usage()
        {
            /*   node 0
             *  /      \
              node1    node2
                       /  \
                   node3   node4
            */
            UsageNumeric();
            UsageText();
            UsageGeneric();
        }

        public static void UsageNumeric()
        {
            NodeNumeric[] nodes = new NodeNumeric[5];
            nodes[0] = new NodeNumeric(0);
            nodes[0].Add(nodes[1] = new NodeNumeric(1));
            nodes[0].Add(nodes[2] = new NodeNumeric(2));
            nodes[2].Add(nodes[3] = new NodeNumeric(3));
            nodes[2].Add(nodes[4] = new NodeNumeric(4));
            Console.WriteLine("Node Text Result :");
            for (int i = 0; i < nodes.Length; i++)
                Console.WriteLine($"Node {i}: {nodes[i].Value} - NodeParent: {nodes[i].Parent?.Value.ToString()}  - NodeChildCount : {nodes[i].Children?.Count}");
        }

        public static void UsageText()
        {
            NodeText[] nodesText = new NodeText[5];
            nodesText[0] = new NodeText("0");
            nodesText[0].Add(nodesText[1] = new NodeText("1"));
            nodesText[0].Add(nodesText[2] = new NodeText("2"));
            nodesText[2].Add(nodesText[3] = new NodeText("3"));
            nodesText[2].Add(nodesText[4] = new NodeText("4"));
            Console.WriteLine("Node Text Result :");
            for (int i = 0; i < nodesText.Length; i++)
                Console.WriteLine($"Node {i}: {nodesText[i].Value} - NodeParent: {nodesText[i].Parent?.Value.ToString()}  - NodeChildCount : {nodesText[i].Children?.Count}");
        }

        public static void UsageGeneric()
        {
            INode[] nodeGenerics = new INode[5];
            nodeGenerics[0] = new NodeText("0");
            nodeGenerics[0].Add(nodeGenerics[1] = new NodeNumeric(1));
            nodeGenerics[0].Add(nodeGenerics[2] = new NodeText("2"));
            nodeGenerics[2].Add(nodeGenerics[3] = new Node<string>("3"));
            nodeGenerics[2].Add(nodeGenerics[4] = new Node<int>(4));

            Console.WriteLine("Node Generics Result :");
            for (int i = 0; i < nodeGenerics.Length; i++)
                Console.WriteLine($"Node {i}: {nodeGenerics[i].Value} - NodeParent: {nodeGenerics[i].Parent?.Value.ToString()}  - NodeChildCount : {nodeGenerics[i].Children?.Count}");

        }
    }
}
