using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateElimination
//UNSORTED ARRAY
//Solution: Nested forloop.

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[] { 1, 3, 2, 3 };
            //This loop starts at index [0].
            for (int i = 0; i < arrayA.Length; i++)
            {
                //This loop starts at index [1].
                for (int x = i + 1; x < arrayA.Length; x++)
                {
                    //If the value at index[0] equals the value at index[1] then we will have found our duplicate.
                    //If not then keep iterating through this forloop until x is no longer less than 4.
                    //Once x is no longer less than 4, we will break out of this loop and jump back up to the outer loop.
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
//We do this by inserted a second forloop that allows us to look at the value at index [1]
//In the second forloop, as x gets incremented, i stays the same.  
//Therefore, we are able to compare the value at index[i] to the value at index[x+],index[x++],index[x+++].
//Once x=4, it is no less than the arrayA.length so we break out of the loop and jump back into the outerloop.
//Now that we are back in the outer loop, i gets incremented to 1 and and we start comparing the values at arrayA[1] to the rest of the values...
//by using the second forloop in the same manner.

//       i              x              
//arrayA[0] = 1, arrayA[1]=3.
//arrayA[1] = 3, arrayA[2]=2.
//arrayA[2] = 2, arrayA[3]=3.
//arrayA[1] = 3, arrayA[2]=3. <--Duplicate Found
//arrayA[2] = 3, arrayA[3]=2.





