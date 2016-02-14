using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Number_Equals_Value //"Magic Index"
//SORTED ARRAY
//A magic index in an array A[1…n-1] is defined to be an index such that A[i] = i. 
//Given a sorted array of distinct integers, write a method to find a magic index if one exists, in an array A..
//Solution:  Do a binary search.

{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
    }
}


//Given:       {-8, -6, 0, 1, 2, 3, 4, 7, 10, 12, 14}
//Index Number:  0,  1, 2, 3, 4, 5, 6, 7, 8,  9,  10
//The magic index in this example is A[7] = 7.  At index 7, the value at that element is equal to 7.
//Step 1 is to perform a binary search and jump to the middle of the index.
//Index is from 0 --> 10.  The midpoint is 10/2 = 5.
//A[5] = 3.  This is not the magic index.
//Since 3 < 5 and this is a sorted array, all values to the left of index 5 has to be less than 3.
//Once again, because it is a sorted array, we know that all values preceding index 5 must be less than 3.
//For example the greatest value that A[4] could be is 2 so the indices cannot ever match the value.
//Therefore, we can eliminate all indices 5 and lower.
//Now we are looking at just the upper half of the array : { 4, 7, 10, 12, 14}
//                                            Index Number:  6, 7,  8,  9, 10
//Find the midpoint of the updated array.  Index 6 --> 10, the midpoint is 8.
//A[8] = 10.  The value 10 does not match the index of 8.
//Since 10 > 8 and this is a sorted array, all values to the right of index 8 has to be greater than 10.
//For example the lowest value that A[9] could be is 11 so the indices cannot ever match the value. 
//Therefore, we can eliminate all indices 8 and greater.
//Now the array is just {4, 7}
//Index Number: 6, 7
//Let's look up the value of each of them since it is a possibility that the magic index does not exist.
//A[6] = 4. Does not match.
//A[7] = 7. <--The magic index exists and it is at index 7.




