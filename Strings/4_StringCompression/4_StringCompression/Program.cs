 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_StringCompression
{
    class Program
    {
        public static string Compress(string word)
        {
            char current = word[0];
            int count = 1;
            string result = "";

            for (int i = 1; i < word.Length; i++)
            {
                if (current == word[i])
                {
                    count++;
                }
                else
                {
                    result += current; result += count;
                    if(result.Length>word.Length)
                    {
                        return word;
                    }
                    current = word[i];
                    count = 1;
                }
            }
            result += current; result += count;
            return result;
        }

        static void Main(string[] args)
        {
            string result = Compress("abcd");
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
}
