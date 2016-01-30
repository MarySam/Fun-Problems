using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateElimination
//UNSORTED ARRAY
//Assumptions: The array contains only one duplicate but can contain any assortment of numbers.
//Solution: Nested forloop.  
//Efficiency: O(n^2)

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[] { 10, 7, 25, 7};
            //This loop starts at index [0].
            for (int i = 0; i < arrayA.Length; i++)
            {
                //This loop starts at index [1].
                for (int x = i + 1; x < arrayA.Length; x++)
                {
                    //If the value at index[0] equals the value at index[1] then we will have found our duplicate.
                    //If not, then keep iterating through this forloop until we have found or duplicate.
                    //Once x is no longer less than 4, we will break out of this loop and jump up to the outer loop.
                    if (arrayA[i] == arrayA[x])
                    {
                        Console.WriteLine("Your duplicate is {0}", arrayA[i]);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}

//We are comparing the value of the array at the first position index = 0 to the rest of the values in the array.
//We do this by inserting a second forloop that allows us to look at the value at index [1].
//In the second forloop, as x gets incremented, i stays the same.  
//Therefore, we are able to compare the value at index[i] to the value at index[x+],index[x++],index[x+++].
//Once x=4, it is no less than the arrayA.length so we break out of the loop and jump back into the outerloop.
//Now that we are back in the outer loop, i gets incremented to 1 and and we start comparing the values at arrayA[1] to the rest of the values...
//by using the second forloop in the same manner.

//       i               x              
//arrayA[0] = 10  arrayA[1]=7.
//arrayA[0] = 10  arrayA[2]=25.
//arrayA[0] = 10  arrayA[3]=7.
//arrayA[1] = 7   arrayA[2]=25. 
//arrayA[1] = 7   arrayA[3]=7. <--Duplicate Found


//The efficiency is O(n^2) because in the worst case, if the duplicates were located at the end of the array, we would've had to check all the elements.







