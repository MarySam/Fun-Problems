using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveValueFromALinkList
{
    class Program
    {
        public static void RemoveValue(LinkedList<int> listA, int value)
        {
            Node<int> curr = listA.Head;

            while (curr != null && curr.Next != null)
            {
                if (curr.Next.Value == value)
                {
                    curr.Next = curr.Next.Next;
                }

                else
                {
                    curr = curr.Next;
                }
            }
        }

        static void Main(string[] args)
        {
    
        }
    }
}
