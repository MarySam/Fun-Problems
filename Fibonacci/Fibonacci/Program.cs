using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] results = GetFibonacci(10);
            PrintArray(results);

            Console.ReadLine();
        }
        //This method accepts a parameter and returns an array of that size.
        public static int[] GetFibonacci(int num)
        {
            int[] results = new int[num];
            if (num > 1)
            {
                results[1] = 1;
            }

            //results[2] = results[0] + results[1];
            //results[3] = results[1] + results[2];
            //results[4] = results[2] + results[3];

            for (int i=2; i<results.Length; i++)
            {
                results[i] = results[i - 2] + results[i - 1];
            }

            return results;
        }

        public static void PrintArray(int[] array)
        {
            if (array == null)
            {
                return;
            }

            Console.Write("[");

            if (array.Length > 0)
            {
                Console.Write(array[0]);
            }

            for (int index = 1; index < array.Length; index++)
            {
                Console.Write(", {0}", array[index]);
            }

            Console.Write("]");
        }
    }
}
