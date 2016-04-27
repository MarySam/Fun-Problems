using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.  Implement an algorithm to determine if a string has all unique characters.
//Solution:  Use a Hashset.


namespace _1_StringAllUniqueCharacters
{
    class Program
    {
        public static Boolean IsUnique(string word)
        {
            HashSet<char> myHash = new HashSet<char>();

            bool result = true;
            foreach(char c in word)
            {
                bool didAdd = myHash.Add(c);
                if (didAdd == false)
                {
                    result = false;
                    break;
                }

                else
                {
                    //redundant since result was already set to true
                    result = true;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            bool result = IsUnique("abcdeff");
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
}




