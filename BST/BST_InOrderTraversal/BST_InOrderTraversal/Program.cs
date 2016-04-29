using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_InOrderTraversal
{
    class Program
    {
        //Iterative 
        public static void inOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Stack<Node> s = new Stack<Node>();

            Node current = root;

            while (true)
            {
                if (current != null)
                {
                    s.Push(current);
                    current = current.left;
                }

                else
                {
                    if (s.Count != 0)
                    {
                        Node popped = s.Pop();
                        Console.WriteLine("Popped: {0}", popped.value);
                        current = popped.right;
                    }
                }
            }
        }

        //Recursive
        public static void inOrderRecur(Node Root)
        {
            if (Root != null)
            {
                inOrderRecur(Root.left);
                Console.WriteLine("In-Order: {0}", Root.value);
                inOrderRecur(Root.right);
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

            //inOrderRecur(myTree.root);
            //Console.ReadLine();

            inOrder(myTree.root);
            Console.ReadLine();

        }
    }

    public class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    public class Tree
    {
        public Node root;

        //constructor
        public Tree()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int num)
        {
            Node newNode = new Node();
            newNode.value = num;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (num < current.value)
                    {
                        current = current.left;

                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }

                    else
                    {
                        current = current.right;

                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
    }
}
