using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_BreadthFirstTraversal
{
    class Program
    {
        public static void breadthFirstQueue(Node root)
        {
            Queue<Node> q = new Queue<Node>();

            if (root == null)
                return;

            q.Enqueue(root);

            while (q.Count > 0)
            {
                Node n = q.Dequeue();
                Console.WriteLine("{0}", n.value);
                Console.ReadLine();
                if (n.left != null)
                {
                    q.Enqueue(n.left);
                }
                if (n.right != null)
                {
                    q.Enqueue(n.right);
                }
            }
        }

        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            myTree.Insert(10);
            myTree.Insert(7);
            myTree.Insert(5);
            myTree.Insert(8);
            myTree.Insert(11);
            myTree.Insert(12);

            breadthFirstQueue(myTree.root);

        }
    }
}

