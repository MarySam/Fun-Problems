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

        public static void SplitArraySum(int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            int target = (sum / 2);
            int temp;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == target)
                {
                    temp = myArray[myArray.Length - 1];
                    myArray[myArray.Length - 1] = myArray[i];
                    myArray[i] = temp;
                }
            }
        }
    }
}
