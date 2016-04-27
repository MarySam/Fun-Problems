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
            char[] updatedSentence = addSpaces(sentence, replaceWith);
            replaceSpaces(updatedSentence, replaceWith);

            foreach (char c in updatedSentence)
            {
                Console.Write("{0}", c);
                Console.ReadLine();
            }

        }

        public static void replaceSpaces(char[] updatedSentence, string replaceWith)
        {
            int insertIndex = updatedSentence.Length - 1;
            int sentenceLength = 0;
            for(int i = insertIndex; i>=0; i--)
            {
                if(updatedSentence[i] != ' ')
                {
                    sentenceLength = i + 1;
                }
            }

            for (int sentenceIndex = sentenceLength-1; sentenceIndex >= 0; sentenceIndex--)
            {
                if (updatedSentence[sentenceIndex] == ' ')
                {
                    for (int i = replaceWith.Length - 1; i >= 0; i--)
                    {
                        updatedSentence[insertIndex] = replaceWith[i];
                        insertIndex--;
                    }
                }
                else
                {
                    updatedSentence[insertIndex] = updatedSentence[sentenceIndex];
                    insertIndex--;
                }
            }

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
            sentence.CopyTo(0, updatedSentence, 0, sentence.Length);

            return updatedSentence;
        }

    }
}


