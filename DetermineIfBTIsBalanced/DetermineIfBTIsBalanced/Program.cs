using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//20.  Given a binary tree, determine if it is balanced.
// Balanced:  A binary tree is balanced if the heights between the sub-trees of any node in the tree is not greater than one.


namespace DetermineIfBTIsBalanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            myTree.Insert(10);
            myTree.Insert(7);
            myTree.Insert(5);
            myTree.Insert(8);
            myTree.Insert(11);
            myTree.Insert(12);
            myTree.Insert(13);
            bool result = checkIfBalanced(myTree.root);

            Console.WriteLine("The tree is {0}balanced", result ? "" : "not ");
            Console.ReadLine();
        }

        public static int GetHeight(Node current)
        {
            if (current == null) return 0;

            int leftHeight = GetHeight(current.left);

            int rightHeight = GetHeight(current.right);

            return (Math.Max(leftHeight, rightHeight) + 1);
        }

        private static int checkBalance(Node current)
        {
            if (current == null) return 0;
            int leftHeight = checkBalance(current.left);
            if (leftHeight == -1)
            {
                return -1;
            }

            int rightHeight = checkBalance(current.right);
            if (rightHeight == -1)
            {
                return -1;
            }

            if (Math.Abs(leftHeight - rightHeight) > 1)
            {
                return -1;
            }

            return (Math.Max(leftHeight, rightHeight) + 1);
        }

        public static bool checkIfBalanced(Node root)
        {
            if (checkBalance(root) == -1)
            {
                return false;
            }

            return true;
        }





    }
}
