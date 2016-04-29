using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAStringTwoPointers
{
    class Program
    {
        public static void ReverseAString(char[] word)
        {
            if (word == null)
            {
                return;
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
        }


        static void Main(string[] args)
        {
            char[] myChar = new char[] { 'c', 'a', 't' };
            ReverseAString(myChar);

            foreach (char c in myChar)
            {
                Console.WriteLine("{0}", c);
                Console.ReadLine();
            }
        }
    }
}

