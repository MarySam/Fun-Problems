using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddInNewArray
{
    class Program
    {
        public static int[] EvenOdd(int[] A)
        {
            int[] B = new int[A.Length];
            int start = 0;
            int end = B.Length - 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B[start] = A[i];
                    start++;
                }

                else
                {
                    B[end] = A[i];
                    end--;
                }
            }

            return B;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 7, 5, 8, 3, 10 };
            int[] B = new int[array.Length];
            B = EvenOdd(array);

            foreach (int v in B)
            {
                Console.WriteLine("{0}", v);
                Console.ReadLine();
            }
        }
    }
}
