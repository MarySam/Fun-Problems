using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpacesofAStringInOnePass
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
            char[] updatedSentence = new char[mySentence.Length];

            int count = 0;
            int spaces = 0;

            for (int i = 0; i <= mySentence.Length - 1; i++)
            {
                if (mySentence[i] != ' ')
                {
                    updatedSentence[count] = mySentence[i];
                    count++;
                }
                else
                {
                    updatedSentence[count] = '\0';
                    spaces++;
                }
            }

            return updatedSentence;
        }
    }
}
