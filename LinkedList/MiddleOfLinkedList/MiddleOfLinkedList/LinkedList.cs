using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOfLinkedList
{
    class LinkedList <T>
    {
        public Node<T> Head { get; set; }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = value;

            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node<T> current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }
    }
}