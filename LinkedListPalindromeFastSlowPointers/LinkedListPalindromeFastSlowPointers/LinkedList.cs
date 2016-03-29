using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPalindromeFastSlowPointers
{
    class LinkedList
    {
        public Node Head { get; set; }

        public void AddLast(object value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }
    }
}
