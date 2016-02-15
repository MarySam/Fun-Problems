using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Number_Equals_Value //"Magic Index"
//SORTED ARRAY
//Problem:  A magic index in an array A[1…n-1] is defined to be an index such that A[i] = i. 
//          Given a sorted array of distinct integers, write a method to find a magic index if one exists, in an array A.
//Solution:  Do a binary search.
//Efficiency: O(log(n))
//   EXAMPLE:     {-8, -6, 0, 1, 2, 3, 4, 7, 10, 12, 14}
//   Index Number:  0,  1, 2, 3, 4, 5, 6, 7, 8,  9,  10


{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[] { -8, -6, 0, 1, 2, 3, 4, 7, 10, 12, 14 };
            int start = 0;
            int end = (arrayA.Length - 1);
            int mp = ((start + end) / 2);

            Console.WriteLine("Start Index: {0}. End Index: {1}", start, end);
            while (arrayA[mp] != mp)
            {
                if (start == end)
                {
                    mp = -1;
                    break;
                }

                if (arrayA[mp] < mp)
                {
                    start = mp+1;
                    mp = ((start + end) / 2);
                    Console.WriteLine("Start Index: {0}. End Index: {1}", start, end);
                    continue;
                }

                if (arrayA[mp] > mp)
                {
                    end = mp-1;
                    mp = ((start + end) / 2);
                    Console.WriteLine("Start Index: {0}. End Index: {1}", start, end);
                    continue;
                }
            }
            if (mp == -1)
            {
                Console.WriteLine("The magic number does not exist");
            }
            else
            {
                Console.WriteLine("The magic index is {0}", mp);
            }
            Console.ReadLine();
        }
    }
}

//Step 1 is to perform a binary search and jump to the middle of the index.
//Index is from 0 --> 10.  The midpoint is (10/2) = 5.
//A[5] = 3.  The index 5 does not match the value 3.  This is not the magic index.
//Since this is a sorted array and 3 < 5, all values to the left of index 5 has to be less than 3.
//For example the greatest value that A[4] could be is 2.  
//So, the indices to the left of index 5 cannot ever match the value and we can eliminate indices 5 and lower.
//Now we are looking at just the upper half of the array : { 4, 7, 10, 12, 14}
//                                            Index Number:  6, 7,  8,  9, 10
//Find the midpoint of the updated array.  Index 6 --> 10, the midpoint is 8.
//A[8] = 10. The index 8 does not match the value 10.  This is not the magic index.
//Since this is a sorted array and 10 > 8, all values to the right of index 8 has to be greater than 10.
//For example the lowest value that A[9] could be is 11.
//So, the indices cannot ever match the value and we can eliminate indices 8 and greater.
//Now the array is just {4, 7}
//         Index Number: 6, 7
//Let's look up the value of each of them since it is a possibility that the magic index does not exist.
//A[6] = 4. The index 6 does not match the value 4.  This is not the magic index.
//A[7] = 7. <--The index 7 does matches the value 7.  This IS the magic index. Yay!




