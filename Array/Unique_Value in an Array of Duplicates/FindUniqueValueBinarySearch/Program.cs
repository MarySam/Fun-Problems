using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//For a sorted array of duplicates, we expect that at each even index (0,2,4 etc), it's pair is to it's right.
//When we do the binary search, if the mp is an odd number, we should expect its pair to be on the left.
//Hence depending on whether or not our mp is even/odd, we check it's left/right element respectively.  
//In our example, the mp is 5, odd.  So let's check the left element.
//Since the element does not equal the mp, then we know that something went awry before we hit this mp.  
//Therefore, the culprit must be somewhere in the left side of the array.  
//So, we can eliminate everything to the right side of the mp and focus our efforts in searching just the left side of the array.
//Now, repeat the steps above.  Look for the mp, is it even or odd?  In the end, everything should be eliminated but
//our unique value itself.  So when the start = end, we should have found our mp.

namespace FindUniqueValueBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example Array:
            int[] arrayA = new int[] { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };

            int value = FindUniqueValue(arrayA);
            Console.WriteLine("{0}", value);
            Console.ReadLine();
        }

        public static int FindUniqueValue(int[] array)
        {
            if (array.Length % 2 == 0)
            {
                return -1;
            }

            int start = 0;
            int end = (array.Length - 1);
 
            while (start < end)
            {
                int mp = ((start + end) / 2);
                int number = mp % 2;

                //If the index value is odd, check the left side.
                if (number != 0)
                {
                    if (array[mp] == array[mp - 1])
                    {
                        start = mp + 1;
                    }

                    else
                    {
                        end = mp - 1;
                    }
                }

                else
                {
                    if (array[mp] == array[mp + 1])
                    {
                        start = mp + 1;
                    }

                    else
                    {
                        end = mp - 1;
                    }
                }
            }

            return array[start];
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
