using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpacesCopyFromTo
{
    class Program
    {

        public static char[] RemoveCharDuplicates(char[] A)
        {
            int k = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != ' ')
                {
                    k++;
                    A[k] = A[i];
                }



            }

            return A;
        }
        static void Main(string[] args)
        {
            char[] A = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'L', 'u', 'c', 'k', 'y' };
            RemoveCharDuplicates(A);


            foreach (char c in A)
                Console.WriteLine("{0}", c);
            Console.ReadLine();
        }
    }
}
