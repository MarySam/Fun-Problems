using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Find1Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 4, 7, 6, 8, 4, 9, 1, 2 };
            int result = FindDuplicate(array);
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }


        public static int FindDuplicate(int[] array)
        {
            int temp = 0;

            while (true)
            {
                WriteArray(array);

                int value = array[0];
                if (value == array[value])
                {
                    return value;
                }

                temp = array[value]; //Saving 7
                array[value] = value;//Setting the array at index 3 to be equal to the value 3.
                array[0] = temp;// Storing 7 in the 0th index.
            }
        }

        private static void WriteArray(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(array[0]);

            for (int index = 1; index < array.Length; index++)
            {
                sb.AppendFormat(", {0}", array[index]);
            }

            Console.WriteLine(sb);
        }
    }
}

