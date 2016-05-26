using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitAnArray_Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 15, 7, 2, 5 };
            SplitArraySum(myArray);

            foreach (int v in myArray)
            {
                Console.WriteLine("{0}", v);
            }

            Console.ReadLine();
        }

        public static void SplitArraySum(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            int target = (sum / 2);
            int end = A.Length - 1;
            int temp = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == target)
                {
                    temp = A[end];
                    A[end] = A[i];
                    A[i] = temp;
                    break;
                }
            }
        }
    }
}
