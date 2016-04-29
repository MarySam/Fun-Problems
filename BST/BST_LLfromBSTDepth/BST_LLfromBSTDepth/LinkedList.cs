using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_LLfromBSTDepth
{
    public class LL_Node<T>
    {
        public T Value { get; set; }
        public LL_Node<T> Next { get; set; }
    }

    class LinkedList<T>
    {
        public int Count { get; set; }

        public LL_Node<T> Head { get; set; }

        public void AddLast(T value)
        {
            LL_Node<T> newNode = new LL_Node<T>();
            newNode.Value = value;
            Count++;
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                LL_Node<T> current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }
    }
}