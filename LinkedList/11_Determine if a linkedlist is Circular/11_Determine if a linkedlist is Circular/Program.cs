using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Determine_if_a_linkedlist_is_Circular
{
    class Program
    {
        public static bool IsCircular (LinkedList ListA)
        {
            Node slow = ListA.Head;
            Node fast = ListA.Head;

            while(fast!=null)
            {
                if(slow!=fast)
                {
                    slow = slow.Next;
                    fast = fast.Next.Next;
                }

                else
                {
                    return true;
                }
            }

            return false;
        }

        public static Node CircleMeet (LinkedList ListA)
        {
            HashSet<Node> myHash = new HashSet<Node>();

            bool didAdd = true;

            Node curr = ListA.Head;
            while(curr!=null)
            {
                didAdd = myHash.Add(curr);
                if(didAdd == false)
                {
                    return curr;
                }

                curr = curr.Next;
            }

            return null;
        }

        static void Main(string[] args)
        {
        }
    }
}
