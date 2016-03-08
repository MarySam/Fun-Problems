using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Value_in_an_Array_of_Duplicates
//SORTED ARRAY
//Problem: Find the element that appears once in a sorted array where all other elements appear twice one after another. 
//         Find that element in 0(logn) complexity.
//Solution: 
//Efficiency: O(log(n)).

{
    class OtherSolution
    {
        static void Main(string[] args)
        {
            //Example Array:
            int[] arrayA = new int[] { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };
            //                         0  1  2  3  4  5  6  7  8  9  10
            int start = 0;
            int end = (arrayA.Length - 1);
            int mp = ((start + end) / 2);
            int mpRight = (mp + 1);

                if (arrayA[mp] == arrayA[mpRight])

                {
                    end = mp - 1;
                    mp = ((start + end) / 2);
                    Console.WriteLine("Start Index: {0}. End Index: {1}", start, end);
                }

                else
                {
                    start = mp + 1;
                    mp = ((start + end) / 2);
                    Console.WriteLine("Start Index: {0}. End Index: {1}", start, end);
                }

            Console.WriteLine("The unique value is {0}", arrayA[mp]);
            Console.ReadLine();
        }
    }
}


//First, let's find the midpoint. There are 11 elements, indexed 0-->10.  Index 10/2 = Index 5.  arrayA[5] =5.    
//Now, let's look at the value to the right of index 5 at index 6.  arrayA[6] = 5.
//The arrayA[6]=5 which matches arrayA[5]=5.
//Since we have an even number of elements on the right side, we know that the unique value cannot be there since all elements...
//...are suppose to appear one after another in duplicate.  So, let's eliminate all elements from index 5 and greater.
//Now arrayA is just {1,1,3,3,4}.  
//Let's find the midpoint once again.  There are 5 elements, indexed 0-->4.  4/2=2.  arrayA[2]=3.
//Let's look at the value to the right of index 2, which is index 3.  arrayA[3] = 3.
//The arrayA[3]=3 which matches arrayA[2]=3.
//Since we have an even number of elements to our left and a single odd element to our right...
//...we know that the unique value must be at index 4.




