using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvenOddIntsInAnArray
{
    class Program
    {

        public static int[] EvenOdd(int[] A)
        {
            int start = 0;
            int end = A.Length - 1;
            int temp = 0;
            while (start < end)
            {
                //If the value is even, just increment the start.
                if (A[start] % 2 == 0)
                {
                    start++;
                }
                //If the value is odd, then let's check the end of the array to see if we could swap it.
                //If the value at the end of the array is already odd then do not swap it. Decrement until we
                //find an even number to swap it with.
                else if (A[end] % 2 != 0)
                {
                    end--;
                }

                else
                {
                    temp = A[start];
                    A[start] = A[end];
                    A[end] = temp;
                    start++;
                    end--;
                }
            }

            return A;
        }
        static void Main(string[] args)
        {
            int[] A = new int[] { 2,16,9,12,4 };
            EvenOdd(A);
            foreach (int v in A)
            {
                Console.WriteLine("{0}", v);
                Console.ReadLine();
            }
        }
    }
}
