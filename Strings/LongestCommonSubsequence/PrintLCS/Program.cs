using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLCS
{
    class Program
    {
        public static int[,] LongestCommonSubsequence(string str1, string str2)
        {
            int[,] array = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    // We have to subtract 1 from i and j to get the correct
                    // index in the string.
                    //For example, for "cat", c is equal to 0. But in the table,
                    //it maps to (1,1).  Therefore, in order to get the right position in the string,
                    //we have to subtract 1.
                    if (str1[i - 1] == str2[j - 1])
                    {
                        array[i, j] = array[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        array[i, j] = Math.Max(array[i - 1, j], array[i, j - 1]);
                    }
                }
            }
            return array;
        }

        public static char[] PrintLCS(int[,] array, string str1, string str2)
        {
            //Intializing an array in which we can pass the LCS into.

            int index = str1.Length;
            char[] LCS = new char[index];

            int i = str1.Length;
            int j = str2.Length;

            //Gets us to the bottom right corner.
            int bottomright = array[i, j];

            while (i > 0 && j > 0)
            {

                if (array[i, j] == array[i - 1, j])
                {
                    i--;
                }

                else if (array[i, j] == array[i, j - 1])
                {
                    j--;
                }

                else
                //If the left and the top are not the same then, let's print the value and move diagonal.
                {
                    //The char array at the last position is set equal to the string at position i-1.
                    LCS[index - 1] = str1[i - 1];
                    i--;
                    j--;
                }
            }
            return LCS;
        }


        static void Main(string[] args)
        {
            int[,] myArray = LongestCommonSubsequence("cat", "at");

            char [] myChar = PrintLCS(myArray, "cat", "at");

            foreach(char c in myChar )
            Console.WriteLine("{0}", c);
            Console.ReadLine();

        }
    }
}
