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
            int[] arrayA = new int[] { 8,7,6,7,6,5,4,3,2,3,4,3 };
            int result = SearchFor(arrayA, 3);
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }

        public static int SearchFor(int[] array, int Num)
        {
            int i = 0;
            while (i < array.Length && array[i] != Num)
            {
                int diff = Math.Abs(array[i] - Num);
                i = i + diff;
            }
                if( i>= array.Length)
                {
                    return -1;
                }

                else
                {
                    return i;
                }
            }
        }
    }

