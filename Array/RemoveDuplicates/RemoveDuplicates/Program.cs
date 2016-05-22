using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        public static int[] RemoveDuplicates(int[] A)
        {
            int j = 0;
            for (int i= 0; i<A.Length; i++)
            {
                if (A[i] !=A[j])
                {
                    j++;
                }

                A[j] = A[i];
            }

            return A;
        }

        static void Main(string[] args)
        {
            int[] arrayA = new int[] { 1, 2, 3, 4, 5, 5, 6, 7, 7, 8, 8, 8, 9, 10, 10 };

            RemoveDuplicates(arrayA);

            foreach(int v in arrayA)
    
            Console.WriteLine("{0}", v);
            Console.ReadLine();
        }
    }
}
