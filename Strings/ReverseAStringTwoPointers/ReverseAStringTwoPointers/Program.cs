using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAStringTwoPointers
{
    class Program
    {
        public static string ReverseAString(char[] word)
        {
            if (word == null)
            {
                return null;
            }

            int start = 0;
            int end = word.Length - 1;
            char temp;

            while (start < end)
            {
                temp = word[start];
                word[start] = word[end];
                word[end] = temp;
                start++;
                end--;
            }

            string s = new string(word);
            return s;
        }


        static void Main(string[] args)
        {
            char[] myChar = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 't', 'o', ' ', 'c', 'o', 'd', 'e'};
            string result = ReverseAString(myChar);
            Console.WriteLine("{0}", result);
            Console.ReadLine();

        }
    }
}

