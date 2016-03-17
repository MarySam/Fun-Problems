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
        static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            string userInput = Console.ReadLine();

            HashSet<char> myHashSet = new HashSet<char>();

            bool isUnique = true;
            foreach (char c in userInput)
            {
                bool didAdd = myHashSet.Add(c);

                if (didAdd == false)
                {
                    isUnique = false;
                    Console.WriteLine("The HashTable already contains {0}", c);
                    break;
                }
                else
                {
                    Console.WriteLine("The letter {0} was added into the HashTable", c);
                }
            }

            if (isUnique == true)
            {
                Console.WriteLine("The word has all unique characters");
            }
            else
            {
                Console.WriteLine("The word does NOT have all unique characters");
            }
            Console.ReadLine();
        }
    }
}




