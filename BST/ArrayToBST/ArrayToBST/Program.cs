using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given an array, create a binary search tree with minimal height.

namespace ArrayToBST
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 7, 8, 10, 11, 12 };
            int start = 0;
            int end = myArray.Length - 1;

            Tree myTree = new Tree();
            arrayToBST(myTree, myArray, start, end);

            Console.WriteLine(myTree);
            Console.ReadLine();
        }

        public static void arrayToBST(Tree myBST, int[] array, int start, int end)
        {
            if (start > end)
                return;

            int mp = ((start + end) / 2);
            myBST.Insert(array[mp]);
            arrayToBST(myBST, array, start, mp - 1);
            arrayToBST(myBST, array, mp+1, end);
        }
    }
}
