using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList listA = new LinkedList();
            listA.AddLast("r");
            listA.AddLast("a");
            listA.AddLast("d");
            listA.AddLast("o");
            listA.AddLast("r");

            Node curr = null;

            Stack<string> myStack = new Stack<string>();

            //Pushing Values into the Stack. 
            curr = listA.Head;
            while (curr != null)
            {
                //Gets the value of the node and converts it into a string.
                string s = (string)curr.Value;

                //Pushing the string into a stack.
                myStack.Push(s);

                //Iterating to the next node.
                curr = curr.Next;
            }

            Console.WriteLine("The Stack contains:");
            Console.WriteLine(GetStackString(myStack));
            Console.ReadLine();

            //Comparing the Node Value to the Stack Value.
            curr = listA.Head;
            while (curr != null)
            {
                //Gets the value of the node and converts it into a string.
                string s = (string)curr.Value;

                //Popping the value from the stack.
                string pop = myStack.Pop();

                Console.WriteLine("Node Value:{0} Stack Value:{1}", s, pop);

                if (pop == s)
                {
                    curr = curr.Next;
                }

                else
                {
                    Console.WriteLine("The word is not a palindrome");
                    break;
                }
            }

            if (curr == null)
            {
                Console.WriteLine("The word is a palindrome");
            }
            Console.ReadLine();
        }


        private static string GetStackString(Stack<string> stack)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in stack)
            {
                sb.AppendLine(s.ToString());
            }

            return sb.ToString();
        }
    }
}


