using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElementFromTwoArrays
{
    class Program
    {
        public static int CommonElement(int[]arrayA, int[]arrayB)
        {
            HashSet<int> myHash = new HashSet<int>();

            for(int i = 0; i<arrayA.Length; i++)
            {
                myHash.Add(arrayA[i]);
            }

            for(int i = 0; i<arrayB.Length; i++)
            {
                if (myHash.Contains(arrayB[i]))
                {
                    return arrayB[i];
                }
            }
            return -1;
        }
        

        static void Main(string[] args)
        {
            int[] arrayA = new int[] { 1, 2, 3, 4, 5 };
            int[] arrayB = new int[] { 6, 7, 8, 9, 10, 11, 5 };
           
            int result =  CommonElement(arrayA, arrayB);

            Console.WriteLine("{0}", result);
            Console.ReadLine();

        }
    }
}
