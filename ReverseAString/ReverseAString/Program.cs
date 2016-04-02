using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myArray = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'i', 'c', 'e', ' ', 'c', 'r', 'e', 'a', 'm', '.', };
            //Before
            //foreach (char c in myArray)
            //{
            //    Console.Write("{0}", c);
            //}

            //Reversing In Place.
            //ReverseChar(myArray);

            //Reversing Using a Stack.
            //ReverseInStack(myArray);

            foreach (char c in myArray)
            {
                Console.Write("{0}", c);
            }

            Console.ReadLine();
        }

        //Reverse every character in place.
        //O(n)
        public static char[] ReverseChar(char[] myArray)
        {
            int start = 0;
            int end = myArray.Length-1;
            char temp;
                while (start < end)
                {
                    temp = myArray[start];
                    myArray[start] = myArray[end];
                    myArray[end] = temp;
                    start++;
                    end--;
                }
            return myArray;
        }

        public static char[] ReverseEachWord (char start)
        {
            char s;
            char temp;

           if(temp == )



        }

        public static void ReverseAWord(char start, char end)
        {
            char temp;
            while (start<end)
            {
                temp = start;
                start = end;
                end = temp;
                start++;
                end--;
            }
        }

        //Reverse every character using a stack.
        //O(2n)? plus addnl data structure(stack).
        public static char[] ReverseInStack(char[] myArray)
        {
            Stack<char> myStack = new Stack<char>();

            foreach (char c in myArray)
            {
                myStack.Push(c);
            }

            for (int i = 0; i <= myArray.Length - 1; i++)
            {
                char Popped = myStack.Pop();
                myArray[i] = Popped;
            }

            return myArray;
        }
    }
}






