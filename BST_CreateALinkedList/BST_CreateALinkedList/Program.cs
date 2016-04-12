using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a linkedlist by traversing a BST breadth first.

namespace BST_CreateALinkedList
{
    class Program
    {
        public static void createLinkedListFromBST(BST_Node root)
        {
            Queue<BST_Node> q = new Queue<BST_Node>();
            LinkedList listA = new LinkedList();

            if (root == null)
                return;

            q.Enqueue(root);

            while (q.Count > 0)
            {
                BST_Node n = q.Dequeue();
                listA.AddLast(n.Value);
                Console.WriteLine("{0}", n.Value);
                //Console.ReadLine();

                if (n.Left != null)
                {
                    q.Enqueue(n.Left);
                }
                if (n.Right != null)
                {
                    q.Enqueue(n.Right);
                }
            }

            WriteLinkedList(listA);
            Console.ReadLine();
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

            createLinkedListFromBST(myTree.root);
        }

        private static void WriteLinkedList(LinkedList list)
        {
            if (list == null)
            {
                return;
            }

            StringBuilder sb = new StringBuilder();

            LL_Node node = list.Head;
            while (node != null)
            {
                sb.AppendFormat("{0} => ", node.Value);
                node = node.Next;
            }

            sb.Append("null");

            Console.WriteLine(sb);
        }
    }
}
