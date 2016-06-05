using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOfLinkedList
{
    class Program
    {

        public static Node<int> Middle (LinkedList<int> listA)
        {
            if (listA.Head == null)
            {
                return null;
            }

            Node<int> slow = listA.Head;
            Node<int> fast = listA.Head;

            while(fast!=null && fast.Next!=null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            return slow;

        }
        static void Main(string[] args)
        {
        }
    }
}
