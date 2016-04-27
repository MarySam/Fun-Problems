﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.  Write a method to replace all spaces in a string with '%20'.
//Strings are immutable so this cannot be done in place.  We will need to create a new string using an array and add 
//the appropriate number of spaces.


namespace ReplaceSpacesInAString
{
    class Program
    {
        public static char[] replaceSpaces(string sentence, string replacewith)
        {
            int spacecount = 0;
            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    spacecount++;
                }
            }

            int totalspaces = sentence.Length + ((replacewith.Length - 1) * spacecount);

            //Now we have a char array with the appropriate number of spaces with nothing in it.
            //Let's copy over from 'sentence' when we do not see a space and insert %20 when we see a space. 
            //Lets start at index 0 of our updatedsentence.
            char[] newSentence = new char[totalspaces];
            int newSentenceIndex = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    foreach (char c in replacewith)
                    {
                        newSentence[newSentenceIndex] = c;
                        newSentenceIndex++;
                    }
                }
                else
                {
                    newSentence[newSentenceIndex] = sentence[i];
                    newSentenceIndex++;
                }
            }
            return newSentence;
        }
        static void Main(string[] args)
        {
            char[] result = replaceSpaces("I love ice cream", "%20");
            foreach (char c in result)
            {
                Console.WriteLine("{0}", c);
                Console.ReadLine();
            }

        }
    }
}
