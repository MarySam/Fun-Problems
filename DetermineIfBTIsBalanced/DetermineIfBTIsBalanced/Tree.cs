using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineIfBTIsBalanced
{
    class Tree
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

