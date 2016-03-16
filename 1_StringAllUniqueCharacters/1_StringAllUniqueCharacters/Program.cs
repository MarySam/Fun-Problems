using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.  Implement an algorithm to determine if a string has all unique characters.


namespace _1_StringAllUniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a word: ");
            string userInput = Console.ReadLine();

            HashSet<char> myHashSet = new HashSet<char>();

            foreach (char c in userInput)
            {
                bool didAdd = myHashSet.Add(c);

                if (didAdd == false)
                {
                    Console.WriteLine("The HashTable already contains {0}", c);
                    break;
                    
                }
                else
                {
                    Console.WriteLine("The letter {0} was added into the HashTable", c);
                }
            }
            Console.ReadLine();
        }
    }
}




