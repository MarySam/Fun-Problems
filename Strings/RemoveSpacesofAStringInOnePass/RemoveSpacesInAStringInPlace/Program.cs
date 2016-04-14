using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpacesInAStringInPlace
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] mySentence = { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'i', 'c', 'e', ' ', 'c', 'r', 'e', 'a', 'm', '.', };
            foreach (char c in mySentence)
            {
                Console.Write("{0}", c);
            }

            char[] updatedSentence = RemoveSpaces(mySentence);
            foreach (char c in updatedSentence)
            {
                Console.Write("{0}", c);
            }
            Console.ReadLine();
        }

        public static char[] RemoveSpaces(char[] mySentence)
        {
            int count = 0;

            for (int i = 0; i <= mySentence.Length - 1; i++)
            {
                if (mySentence[i] != ' ')
                {
                    mySentence[count] = mySentence[i];
                    count++;
                }
                else
                {
                    mySentence[count] = '\0';
                }
            }

            for (int i = count; i <= mySentence.Length-1; i++)
            {
                mySentence[i] = '\0';
            }

            return mySentence;
        }
    }
}


