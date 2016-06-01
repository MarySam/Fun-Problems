using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseALinkedListIteratively
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList listA = new LinkedList();
            listA.AddLast(1);
            listA.AddLast(2);
            listA.AddLast(3);
            listA.AddLast(4);
            listA.AddLast(5);

            DisplayLinkedList(listA);

            Console.WriteLine("ListA has been reversed");
            DisplayLinkedList(listA);
        }

        public static void ReverseLinkedList(LinkedList ListA)
        {
            Node prev = null;
            Node curr = null;
            Node next = null;

            curr = ListA.Head;
            
            while(curr!=null)
            {
                //Save the next pointer.
                next = curr.Next;
                //Flip the next pointer to the previous node.
                curr.Next = prev;
                //Update the previous pointer to point to the current node.
                prev = curr;
                //Move the current pointer to the next node.
                curr = next;
            }

            ListA.Head = prev;
            
        }

        private static void DisplayLinkedList(LinkedList list)
        {
            Console.WriteLine("ListA contains the following integers: ");
            {
                Node current = list.Head;

                while (current != null)
                {
                    Console.Write(current.Value + " -> ");
                    current = current.Next;
                }
            }
            Console.ReadLine();
        }
    }
}
