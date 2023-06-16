using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics.Raw
{
    public static class Test
    {

       static  NodeNumeric[] nodes = new NodeNumeric[5];
        static NodeText[] nodesText = new NodeText[5];

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

            WriteResult();
        }

        public static void WriteResult()
        {
            for (int i = 0; i < nodes.Length; i++)
                Console.WriteLine($"Node {i}: {nodes[i].Value} - NodeParent: {nodes[i].Parent?.Value.ToString()}  - NodeChildCount : {nodes[i].Children?.Count}");
        }

        public static void UsageNumeric()
        {
             nodes = new NodeNumeric[5];
            nodes[0] = new NodeNumeric(0);
            nodes[0].Add(nodes[1] = new NodeNumeric(1));
            nodes[0].Add(nodes[2] = new NodeNumeric(2));
            nodes[2].Add(nodes[3] = new NodeNumeric(3));
            nodes[2].Add(nodes[4] = new NodeNumeric(4));
        }

        public static void UsageText()
        {
            nodesText = new NodeText[5];
            nodesText[0] = new NodeText("0");
            nodesText[0].Add(nodesText[1] = new NodeText("1"));
            nodesText[0].Add(nodesText[2] = new NodeText("2"));
            nodesText[2].Add(nodesText[3] = new NodeText("3"));
            nodesText[2].Add(nodesText[4] = new NodeText("4"));
        }

    }
}
