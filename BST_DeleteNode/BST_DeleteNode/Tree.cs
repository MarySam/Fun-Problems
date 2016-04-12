using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_DeleteNode
{
    public class Tree
    {
        public Node root;

        //constructor
        public Tree()
        {
            root = null;
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
                            newNode.parent = parent;
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;

                        if (current == null)
                        {
                            newNode.parent = parent;
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public Node FindNode(int num)
        {
            Node current = root;
            while (current != null && current.value != num)
            {
                if (num < current.value)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            return current;
        }

        public void DeleteNode(int num)
        {
            Node nodeToDelete = FindNode(num);
            if (nodeToDelete == null)
            {
                return;
            }

            //Case 1:  Deleting Leaf nodes which have no children.
            if (nodeToDelete.left == null && nodeToDelete.right == null)
            {
                if (nodeToDelete == root)
                {
                    root = null;
                }
                else if (nodeToDelete == nodeToDelete.parent.right)
                {
                    nodeToDelete.parent.right = null;
                }
                else if (nodeToDelete == nodeToDelete.parent.left)
                {
                    nodeToDelete.parent.left = null;
                }
                return;
            }

            //Case 2:  Deleting nodes that have one child.
            //If we are deleting a node that has a right child.
            if (nodeToDelete.left == null)
            {
                if (nodeToDelete == root)
                {
                    //Change the root to be pointing to the right child.
                    root = nodeToDelete.right;
                    //Now that the right child is the root, set the right child's parent to be equal to null.
                    nodeToDelete.right.parent = null;
                }
                //If the node to delete is not a root.
                else
                {
                    //Change the nodetodelete's parent's right pointer to point to the nodetodelete's right child.
                    nodeToDelete.parent.right = nodeToDelete.right;
                    //Change the nodetodelete's right child parent pointer to point to the nodetodelete's parent.
                    nodeToDelete.right.parent = nodeToDelete.parent;
                }
                return;
            }
            //If we are deleting a node that has a left child.
            if (nodeToDelete.right == null)
            {
                if (nodeToDelete == root)
                {
                    root = nodeToDelete.left;
                    nodeToDelete.left.parent = null;
                }
                else
                {
                    nodeToDelete.parent.left = nodeToDelete.left;
                    nodeToDelete.left.parent = nodeToDelete.parent;
                }
                return;
            }

            //Case 3:  If the node to delete has both a right child and a left child.
            //If the nodetodelete's right child does not have a left child.
            if (nodeToDelete.right.left == null)
            {
                //If the nodetoDelete is the root.
                if (nodeToDelete == root)
                {
                    root = nodeToDelete.right;
                }
                //If it has a parent on the left side.
                else if (nodeToDelete == nodeToDelete.parent.right)
                {
                    nodeToDelete.parent.right = nodeToDelete.right;
                }
                //If it has a parent on the right side.
                else
                {
                    nodeToDelete.parent.left = nodeToDelete.right;
                }
                nodeToDelete.right.parent = nodeToDelete.parent;
                nodeToDelete.right.left = nodeToDelete.left;
                nodeToDelete.left.parent = nodeToDelete.right;
            }

            //Case 4:  If the nodetodelete's right child does have a left child.  We have to find the leftmost.
            Node leftmost = nodeToDelete.right.left;
            Node lmParent = nodeToDelete.right;
            //Find the leftmost.
            while (leftmost.left != null)
            {
                lmParent = leftmost;
                leftmost = leftmost.left;
            }
            if (nodeToDelete == root)
            {
                //Deleting the root.
                root = leftmost;
            }
            else if (nodeToDelete == nodeToDelete.parent.right)
            {
                nodeToDelete.parent.right = leftmost;
            }
            else
            {
                nodeToDelete.parent.left = leftmost;
            }
            lmParent.left = leftmost.right;
            leftmost.right = nodeToDelete.right;
            leftmost.left = nodeToDelete.left;
            nodeToDelete.left.parent = leftmost;
            nodeToDelete.right.parent = leftmost;
        }
    }
}

