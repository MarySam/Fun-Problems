using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharactersHashset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            string s1 = Console.ReadLine();

            bool check = isUnique(s1);

            if (check != true)
            {
                Console.WriteLine("The word does NOT have all unique characters");
            }
            else
            {
                Console.WriteLine("The word has all unique characters");
            }
            Console.ReadLine();

        }

        public static bool isUnique(string s1)
        {
            HashSet<char> myHashSet = new HashSet<char>();

            foreach (char c in s1)
            {
                bool didAdd = myHashSet.Add(c);

                if (didAdd == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
