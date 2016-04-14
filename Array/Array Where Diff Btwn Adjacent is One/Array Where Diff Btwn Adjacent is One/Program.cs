using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Where_Diff_Btwn_Adjacent_is_One
//Problem: Search an element in an array where the difference between adjacent elements is 1.
//Solution:  Take the value at A[0] and subtract it from the value of the element in question. 
//           Take this difference and add it to the index value.
//           Look up the value of the array at this new index number.
//           If not found then repeat the steps above.
//Efficiency: ?
// Example:  Find the element 4.
//       Array A:     { 3, 2, 1, 2, 3, 4, 3, 4, 5}
//       Index Value:   0  1  2  3  4  5  6  7  8    


{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[] { 3, 2, 1, 2, 3, 2, 3, 4, 5 };
            int i = 0;
            int searchValue = GetUserInt();

            while (i < arrayA.Length && arrayA[i] != searchValue)
            {
                int diff = Math.Abs(arrayA[i] - searchValue);
                i = i + diff;

                Console.WriteLine("Didn't find element at index {0}. Looking at index {1} next.", i - diff, i);
            }

            if (i >= arrayA.Length)
            {
                Console.WriteLine("The element {0} was not found", searchValue);
            }
            else
            {
                Console.WriteLine("The element {0} was found at index {1}", searchValue, i);
            }

            Console.ReadLine();
        }

        private static int GetUserInt()
        {
            Console.Write("Please enter the value to search for: ");
            string userInput = Console.ReadLine();
            return int.Parse(userInput);
        }
    }
}
