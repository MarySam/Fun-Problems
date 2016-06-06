using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSpacesInPlace2
{
    class Program
    {

        public static char[] ReplaceSpaces(char[] s1, char[] insert)
        {
            int nonspace = 0;
            int k = s1.Length - 1;

            //Find out where j starts.
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i] != ' ')
                {
                    nonspace = i;
                    break;
                }
            }

            for (int j = nonspace; j >= 0; j--)
            {
                if (s1[j] != ' ')
                {
                    s1[k] = s1[j];
                    k--;
                }

                else
                {
                    //Insert starting at the last position.
                    for (int i = insert.Length - 1; i >= 0; i--)
                    {
                        s1[k] = insert[i];
                        k--;
                    }
                }
            }

            return s1;

        }


        static void Main(string[] args)
        {

            char[] s1 = { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'c', 'o', 'd', 'i', 'n', 'g', ' ', ' ', ' ', ' ' };
            char[] insert = { '%', '2', '0' };
            char[] result = ReplaceSpaces(s1, insert);

            foreach(char c in result)
            {
                Console.WriteLine("{0}", c);
                Console.ReadLine();
            }

        }
    }
}
