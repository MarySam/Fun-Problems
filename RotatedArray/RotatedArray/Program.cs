using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 4, 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            //RotatedArray(myArray, 2);

            Console.WriteLine("{0}", RotatedArray(myArray, 6));
            Console.ReadLine();
        }

        public static int RotatedArray(int[] A, int Number)
        {
            int start = 0;
            int end = A.Length - 1;


            while (start <= end)
            {
                int mp = ((start + end) / 2);
                if (A[mp] == Number)
                {
                    return mp;
                }
                if (A[start] <= A[mp])
                {
                    if (A[start] <= Number && Number <= A[mp])
                    {
                        end = mp - 1;
                    }

                    else
                    {
                        start = mp + 1;
                    }
                }
                else
                {
                    if (A[mp] <= Number && Number <= A[end])
                    {
                        start = mp + 1;
                    }
                    else
                    {
                        end = mp - 1;
                    }
                }

            }
            return -1;
        }
    }
}
