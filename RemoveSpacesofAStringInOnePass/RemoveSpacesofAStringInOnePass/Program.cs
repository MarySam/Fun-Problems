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
            char[] result = RemoveSpaces(mySentence);

            foreach (char c in mySentence)
            {
                Console.Write("{0}", c);
            }

            foreach (char c in result)
            {
                Console.Write("{0}", c);
               
            }
            Console.ReadLine();
        }

        public static char[] RemoveSpaces(char[] sentence)
        {
            char[] mySentence = new char[sentence.Length];

            int count = 0;

            for (int i = 0; i < mySentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    mySentence[count] = sentence[i];
                    count++;
                }
                mySentence[count] = '\0';
            }
            return mySentence;
        }
    }
}
