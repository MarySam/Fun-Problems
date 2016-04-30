using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAStringByCreatingNew
{
    class Program
    {
        public static string ReverseAString(string word)
        {
            char[] myArray = new char[word.Length];

            int start = 0;
            for (int i = (word.Length - 1); i >= 0; i--)
            {
                myArray[start] = word[i];
                start++;
            }

            string s = new string(myArray);
            return s;
        }

        static void Main(string[] args)
        {
            string result = ReverseAString("cat");

            Console.WriteLine("{0}", result);
            Console.ReadLine();

        }

    }
}


//int end = word.Length - 1;
//            for (int i = 0; i<word.Length; i++)
//            {
//                myArray[i] = word[end];
//                end--;
//            }

  //for (int i = 0; i<word.Length; i++)
  //          {
  //              myArray[myArray.Length - 1 - i] = word[i];
  //          }