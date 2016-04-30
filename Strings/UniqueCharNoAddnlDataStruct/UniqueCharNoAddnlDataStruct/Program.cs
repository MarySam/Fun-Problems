using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharNoAddnlDataStruct
{
    class Program
    {
        public static bool IsUnique(string word)
        {
            bool isUnique = true;
            for(int i=0; i<word.Length;i++)
            {
                for(int j=i+1; j<word.Length; j++)
                {
                    if(word[i]==word[j])
                    {
                        isUnique = false;
                    }
                }
            }
            return isUnique;
        }

        static void Main(string[] args)
        {
            bool result = IsUnique("taco");
            Console.WriteLine("{0}", result);
            Console.ReadLine();

        }
    }
}
