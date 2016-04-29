using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_LLfromBSTDepth
{
    class Program
    {
        public static List<LinkedList<BST_Node>> LLfromBST(BST_Node root)
        {
            if (root == null)
                return null;

            List<LinkedList<BST_Node>> finalList = new List<LinkedList<BST_Node>>();
            LinkedList<BST_Node> linkListA = new LinkedList<BST_Node>();

            linkListA.AddLast(root);
            finalList.Add(linkListA);

            while (linkListA.Count > 0)
            {
                LinkedList<BST_Node> linkListB = new LinkedList<BST_Node>();
                LL_Node<BST_Node> current = linkListA.Head;

                while (current != null)
                {
                    if (current.Value.Left != null)
                    {
                        linkListB.AddLast(current.Value.Left);
                    }

                    if (current.Value.Right != null)
                    {
                        linkListB.AddLast(current.Value.Right);
                    }
                    current = current.Next;
                }
                finalList.Add(linkListB);
                linkListA = linkListB;
            }
            return finalList;
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

            List<LinkedList<BST_Node>> finalList = LLfromBST(myTree.root);
            WriteListOfLinkedList(finalList);
            Console.ReadLine();

        }

        private static void WriteListOfLinkedList(List<LinkedList<BST_Node>> list)
        {
            foreach (LinkedList<BST_Node> l in list)
            {
                WriteLinkedList(l);
            }
        }

        private static void WriteLinkedList(LinkedList<BST_Node> list)
        {
            if (list == null)
            {
                return;
            }

            StringBuilder sb = new StringBuilder();

            LL_Node<BST_Node> node = list.Head;
            while (node != null)
            {
                sb.AppendFormat("{0} => ", node.Value.Value);
                node = node.Next;
            }

            sb.Append("null");

            Console.WriteLine(sb);
        }
    }
}
