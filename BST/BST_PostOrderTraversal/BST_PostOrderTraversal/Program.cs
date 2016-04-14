using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_PostOrderTraversal
{
    class Program
    {
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

        //Iterative Method
        public static void postOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            HashSet<Node> myHash = new HashSet<Node>();
            Stack<Node> myStack = new Stack<Node>();

            Node current = root;

            while (true)
            {
                if (current.left != null && myHash.Add(current.left))
                {
                    myStack.Push(current);
                    current = current.left;
                }
                else if (current.right != null && myHash.Add(current.right))
                {
                    myStack.Push(current);
                    current = current.right;
                }
                else if (myStack.Count == 0)
                {
                    Console.WriteLine("Post-Order: {0}", current.value);
                    break;
                }
                else
                {
                    Console.WriteLine("Post-Order: {0}", current.value);
                    current = myStack.Pop();
                }
            }
        }

        //Recursive 
        public static void postOrderRecur(Node root)
        {
            Node current = root;
            if (current != null)
            {
                postOrderRecur(current.left);
                postOrderRecur(current.right);
                Console.WriteLine("Post-Order: {0}", current.value);
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

            postOrder(myTree.root);
            //postOrderRecur(myTree.root);
            Console.ReadLine();
        }
    }
}

