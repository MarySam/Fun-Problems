using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrderOfWordsInASentence
{
    class Program
    {
        public static void ReverseA(char[] sentence)
        {
            int start = 0;
            int end = sentence.Length - 1;
            char temp;

            while(start<end)
            {
                temp = sentence[start];
                sentence[start] = sentence[end];
                sentence[end] = temp;
                start++;
                end--;
            }
        }
        public static void ReverseB(char[] sentence,int start, int end)
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

        public static string ReverseC(char [] word)
        {
            int start = 0;
            int end = 0;
            for(int i = 0; i<word.Length; i++)
            {
                if(word[i]==' ')
                {
                    end = i - 1;
                    ReverseB(word, start, end);
                    start = i + 1;
                }
            }
            end = word.Length - 1;
            ReverseB(word, start, end);
            string s = new string(word);
            return s;
        }


        static void Main(string[] args)
        {
            char[] myChar = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 't', 'o', ' ', 'c', 'o', 'd', 'e' };
            ReverseA(myChar);
            string result = ReverseC(myChar);
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
}
