using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first word: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Please enter the second word: ");
            string s2 = Console.ReadLine();

            bool check = isAnagram(s1, s2);

            if (check != true)
            {
                Console.WriteLine("Not anagrams");
            }

            else
            {
                Console.WriteLine("The words are anagrams");
            }
            Console.ReadLine();
        }

        public static bool isAnagram(string s1, string s2)
        {
            Dictionary<char, int> myDictionary = new Dictionary<char, int>();

            if (s1.Length != s2.Length)
            {
                return false;
            }

            foreach (char c in s1)
            {
                //If the dictionary does not have the key, add the key and set the value to 1.
                if (!myDictionary.ContainsKey(c))
                {
                    myDictionary.Add(c, 1);
                }
                //If the dictionary already has the key, increment the value by 1.
                else
                {
                    myDictionary[c]++;
                }
            }

            foreach (char c in s2)
            {
                //If the char in s2 is in the dictionary, decrement the value in the dictionary.
                if (myDictionary.ContainsKey(c))
                {
                    myDictionary[c]--;
                }
            }

            foreach (int v in myDictionary.Values)
            {
                if (v != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}


