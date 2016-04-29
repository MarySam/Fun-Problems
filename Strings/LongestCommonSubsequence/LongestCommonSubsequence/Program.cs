using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubsequence
{
    class Program
    {

        public static int[,] LongestCommonSubsequence(string str1, string str2)
        {
            int[,] array = new int[str1.Length + 1, str2.Length +1];
            
            for(int i=1; i<= str1.Length; i++)
            {
                for (int j= 1; j<=str2.Length; j++)
                {
                    // We have to subtract 1 from i and j to get the correct
                    // index in the string
                    if(str1[i-1] == str2[j-1])
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

        public static HashSet<string> GetSubsequences(int[,] array, string str1, int startI, int startJ)
        {
            int currentValue = array[startI, startJ];

            // If the value at the current cell is 0, we're done.
            if (currentValue == 0) return new HashSet<string>();

            // Otherwise, we need to look to the left...
            HashSet<string> results = new HashSet<string>();
            if (currentValue == array[startI - 1, startJ])
            {
                foreach (string s in GetSubsequences(array, str1, startI - 1, startJ))
                {
                    results.Add(s);
                }
            }

            // ... and the top. If the values match the current cell's
            // value, recursively call this method.
            if (currentValue == array[startI, startJ - 1])
            {
                foreach (string s in GetSubsequences(array, str1, startI, startJ - 1))
                {
                    results.Add(s);
                }
            }

            // If we matched the left or top value, just return those results.
            if (results.Count > 0)
            {
                return results;
            }

            // Otherwise, we're in a corner and need to jump diagonally.
            // Grab the current letter and append it to all the subsequent sequences.
            char currentLetter = str1[startI - 1];
            if (currentValue == 1)
            {
                results.Add(currentLetter.ToString());
                return results;
            }

            HashSet<string> childResults = GetSubsequences(array, str1, startI - 1, startJ - 1);
            foreach (string result in childResults)
            {
                results.Add(result + currentLetter);
            }

            return results;
        }

        static void Main(string[] args)
        {
            string string1 = "AGGTAB";
            string string2 = "GXTXAYB";

            int[,] array = LongestCommonSubsequence(string1, string2);
            HashSet<string> sequences = GetSubsequences(array, string1, string1.Length, string2.Length);

            foreach (string result in sequences)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
