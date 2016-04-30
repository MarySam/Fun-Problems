using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrderOfWordsInASentence
{
    class Program
    {
        public static void ReverseRange(char[] sentence,int start, int end)
        {
            char temp;

            while (start < end)
            {
                temp = sentence[start];
                sentence[start] = sentence[end];
                sentence[end] = temp;
                start++;
                end--;
            }
        }

        public static string ReverseWords(char [] sentence)
        {
            int start = 0;
            int end = 0;
            for(int i = 0; i<sentence.Length; i++)
            {
                if(sentence[i]==' ')
                {
                    end = i - 1;
                    ReverseRange(sentence, start, end);
                    start = i + 1;
                }
            }

            // We still have to reverse the last word, once the loop is done.
            end = sentence.Length - 1;
            ReverseRange(sentence, start, end);
            string s = new string(sentence);
            return s;
        }


        static void Main(string[] args)
        {
            char[] myChar = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 't', 'o', ' ', 'c', 'o', 'd', 'e' };
            ReverseRange(myChar, 0, myChar.Length - 1);
            string result = ReverseWords(myChar);
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
}
