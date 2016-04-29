using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToBST
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            List<Node> nodes = new List<Node>();
            nodes.Add(this.root);

            while (nodes.Count > 0)
            {
                List<Node> childNodes = new List<Node>();

                foreach (Node current in nodes)
                {
                    sb.Append(current.value + " ");
                    if (current.left != null) childNodes.Add(current.left);
                    if (current.right != null) childNodes.Add(current.right);
                }

                nodes = childNodes;
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}


