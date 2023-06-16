using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tree_Generics.Generic
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

            //UsageNumeric();
            UsageFolder();
        }
        public static void UsageNumeric()
        {
            Node<int>[] nodes = new Node<int>[5];
            nodes[0] = new Node<int>(0);
            nodes[0].Add(nodes[1] = new Node<int>(1));
            nodes[0].Add(nodes[2] = new Node<int>(2));
            nodes[2].Add(nodes[3] = new Node<int>(3));
            nodes[2].Add(nodes[4] = new Node<int>(4));
        }


        public static void UsageFolder()
        {
            var path  = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var rootDirectoryInfo = new FileInfo(path).Directory.Parent.Parent.Parent;
            var root = Folder.BuildTree(rootDirectoryInfo);

            foreach(var folder in root.GetDescendentsAndSelf())
            {
                Console.Write(String.Join(String.Empty, Enumerable.Repeat("   ", folder.GetAncestors().Count())));
                Console.WriteLine(folder.Value.Name);
            }
        }
    }
}
