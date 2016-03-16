using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.  Given two strings, write a method to decide if one is a permutation of the other?
//Solution:  Use a dictionary.
//Efficieny:  O(n)

namespace CheckForAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first word: ");
            string userInput1 = Console.ReadLine();

            Console.WriteLine("Please enter the second word: ");
            string userInput2 = Console.ReadLine();

            Dictionary<char, int> myDictionary = new Dictionary<char, int>();

            int length1 = userInput1.Length;
            int length2 = userInput2.Length;

            if (length1 == length2)
            {
                foreach (char s in userInput1)
                {
                    //If the dictionary does not have the key, add the key and set a value of 1.
                    if (!myDictionary.ContainsKey(s))
                    {
                        myDictionary.Add(s, 1);
                    }
                    //If the dictionary has the key, increment the value by 1.
                    else
                    {
                        myDictionary[s]++;
                    }
                }

                foreach (char c in userInput2)
                {
                    //If the char in userInput2 is in the dictionary, decrement the count in the dictionary.
                    if (myDictionary.ContainsKey(c))
                    {
                        myDictionary[c]--;
                    }
                }

                bool isAnagram = true;
                foreach (int v in myDictionary.Values)
                {
                    if (v != 0)
                    {
                        isAnagram = false;
                        break;
                    }
                }

                if (isAnagram == true)
                {
                    Console.WriteLine("The words are anagrams");
                }

                else
                {
                    Console.WriteLine("The words are NOT anagrams");
                }
            }

            else
            {
                Console.WriteLine("Not anagrams");
            }
            Console.ReadLine();
        }
    }
}
