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

            char[] mySentence = { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'c', 'o', 'd', 'i', 'n', 'g', '.'};
            //foreach (char c in mySentence)
            //{
            //    Console.Write("{0}", c);
            //}

            char[] updatedSentence = RemoveSpaces(mySentence);
            foreach (char c in updatedSentence)
            {
                Console.Write("{0}", c);
            }
            Console.ReadLine();
        }

        public static char[] RemoveSpaces(char[] mySentence)
        {
            int j = 0;

            for (int i = 0; i <= mySentence.Length - 1; i++)
            {
                if (mySentence[i] != ' ')
                {
                    mySentence[j] = mySentence[i];
                    j++;
                }
                else
                {
                    mySentence[j] = '\0';
                }
            }

            //Removing the last characters at the end.
            for (int i = j; i <= mySentence.Length - 1; i++)
            {
                mySentence[i] = '\0';
            }

            return mySentence;
        }
    }
}


