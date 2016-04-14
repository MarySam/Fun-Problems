using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_CreateALinkedList
{
    public class LL_Node
    {
        public object Value { get; set; }
        public LL_Node Next { get; set; }
    }

    class LinkedList
    {
        public LL_Node Head { get; set; }

        public void AddLast(object value)
        {
            LL_Node newNode = new LL_Node();
            newNode.Value = value;

            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                LL_Node current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }
    }
}