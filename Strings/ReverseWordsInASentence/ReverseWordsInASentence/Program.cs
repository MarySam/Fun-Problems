using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsInASentence
{
    class Program
    {
        public static string ReverseSentence(char[] sentence)
        {
            int start = 0;
            int end = 0;

            for(int i=0; i<sentence.Length; i++)
            {
                if(sentence[i]==' ')
                {
                    end = i - 1;
                    ReverseWord(sentence, start, end);
                    start =i+1;
                }
            }
            end = sentence.Length-1;
            ReverseWord(sentence, start, end);

            string s = new string(sentence);
            return s;
        }

        public static void ReverseWord(char[] word, int start, int end)
        {
            char temp;
            while(start<end)
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
            char[] myChar = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 't', 'o', ' ', 'c', 'o', 'd', 'e' };
            string result = ReverseSentence(myChar);
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
}
