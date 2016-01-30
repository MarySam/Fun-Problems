using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateElimination
//UNSORTED ARRAY
//If the following Assumptions are true:
//  1. The array is only from 1--> n.As in 1 to 5.
//  2. The array contains only one duplicate.
//Solution: Use One forloop and do a simple mathematical calculation.
//Efficiency: O(n) <--Best case for this scenario. We are looking up the values in the forloop only once.
{
    class OtherSolutions
{
    static void Main(string[] args)
    {

        int[] arrayA = new int[] { 1, 3, 2, 3, 4 };
        int total = 0;
        for (int i = 0; i < arrayA.Length; i++)
        {
            total = total + arrayA[i];
        }

        int theoreticalValue = ((arrayA.Length * (arrayA.Length - 1)) / 2);

        int difference = (total - theoreticalValue);

        Console.WriteLine("The duplicate for this array is {0}", difference);
        Console.ReadLine();
    }
}
}

//We can perform a simple mathematical calculation to obtain an efficiency of O(n).
//1. Sum up the values of the array using a for loop. In our example, the total = 13.
//2. Obtain a theoretical value for the array given the number of elements.
//   Utilize the following equation: (n*(n-1))/2. 
//   Total number of elements = 5.  So the result in our example is (5*(5-1))/2 = 10.
//3. Subtract the two values from one another to get the duplicate:  13-10 = 3. <--The duplicate.
