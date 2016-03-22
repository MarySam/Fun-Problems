using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSpacesInAStringInPlace
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Please enter some characters to replace the spaces: ");
            string replaceWith = Console.ReadLine();

            char[] updatedSentence = replaceSpaces(sentence, replaceWith);

            foreach (char c in updatedSentence)
            {
                Console.Write("{0}", c);
                Console.ReadLine();
            }

        }

        public static char[] replaceSpaces(string sentence, string replaceWith)
        {
            char[] updatedSentence = addSpaces(sentence, replaceWith);

            int sentenceIndex = sentence.Length - 1;
            int insertIndex = updatedSentence.Length - 1;
            int replaceWithIndex = replaceWith.Length - 1;

            for (sentenceIndex = sentence.Length - 1; sentenceIndex >= 0; sentenceIndex--)
            {
                if (sentence[sentenceIndex] == ' ')
                {
                    for (int i = replaceWithIndex; i >= 0; i--)
                    {
                        updatedSentence[insertIndex] = replaceWith[i];
                        insertIndex--;
                    }
                }
                else
                {
                    updatedSentence[insertIndex] = sentence[sentenceIndex];
                    insertIndex--;
                }
            }

            return updatedSentence;
        }

        public static char[] addSpaces(string sentence, string replaceWith)
        {
            int spaceCount = 0;
            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }

            int count = (sentence.Length + ((replaceWith.Length - 1) * spaceCount));

            char[] updatedSentence = new char[count];

            return updatedSentence;
        }

    }
}


