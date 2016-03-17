using System;
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
        static void Main(string[] args)
        {
            string sentence = "I love ice cream.";
            string insert = "%20";
            int spaceCount = 0;

            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }

            int count = (sentence.Length + ((insert.Length - 1) * spaceCount));

            char[] myArray = new char[count];

            int arrayIndex = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    foreach (char c in insert)
                    {
                        myArray[arrayIndex] = c;
                        arrayIndex++;
                    }
                 }

                else
                {
                    myArray[arrayIndex] = sentence[i];
                    arrayIndex++;
                }
            }

            foreach (char c in myArray)
            {
                Console.Write("{0}", c);
            }
            Console.ReadLine();
        }
    }
}
