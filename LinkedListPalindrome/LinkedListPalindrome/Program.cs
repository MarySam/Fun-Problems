using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DOUBLY LinkedList
namespace LinkedListPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> listA = new LinkedList<string>();
            listA.AddLast("r");
            listA.AddLast("a");
            listA.AddLast("d");
            listA.AddLast("a");
            listA.AddLast("r");

            LinkedListNode<string> head = listA.First;
            LinkedListNode<string> tail = listA.Last;

            while (head != null)
            {
                Console.WriteLine("Head: {0} , Tail: {1}", head.Value, tail.Value);
               
                if (head.Value == tail.Value)
                {
                    //Moving the nodes
                    head = head.Next;
                    tail = tail.Previous;
                }

                else
                {
                    Console.WriteLine("The word is not a palindrome");
                    break;
                }

            }

            if (head == null)
            {
                Console.WriteLine("The word is a palindrome");
            }
            Console.ReadLine();


            //PrintList(listA);
            //PrintReversedList(listA);
        }


        private static void PrintList<T>(LinkedList<T> list)
        {
            Console.WriteLine("Linked list: ");
            foreach (T value in list)
            {
                Console.Write("{0} ", value);
            }
            Console.ReadLine();
        }

        private static void PrintReversedList<T>(LinkedList<T> list)
        {
            Console.WriteLine("Reversed List:");

            //iterate over the list by using the nodes
            LinkedListNode<T> currentNode = list.Last;

            while (currentNode != null)
            {
                Console.Write("{0} ", currentNode.Value);
                currentNode = currentNode.Previous;

            }
            Console.ReadLine();
        }


    }
}



