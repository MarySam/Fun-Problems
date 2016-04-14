using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_LLfromBSTDepth
{
    public class BST_Node
    {
        public int Value { get; set; }
        public BST_Node Left { get; set; }
        public BST_Node Right { get; set; }
    }

    public class Tree
    {
        public BST_Node root;

        //constructor
        public Tree()
        {
            root = null;
        }

        public BST_Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int num)
        {
            BST_Node newNode = new BST_Node();
            newNode.Value = num;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BST_Node current = root;
                BST_Node parent;
                while (true)
                {
                    parent = current;
                    if (num < current.Value)
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }

                    else
                    {
                        current = current.Right;

                        if (current == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }
    }
}
