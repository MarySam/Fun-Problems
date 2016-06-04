using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromAnUnsortedLList
{
    class Program
    {
        public static void RemoveDuplicates(LinkedList<int> listA)
        {
            Node<int> curr = listA.Head;

            HashSet<int> myHash = new HashSet<int>();

            bool didAdd = true;

            myHash.Add(curr.Value);

            while(curr!=null && curr.Next !=null)
            {
                didAdd = myHash.Add(curr.Next.Value);

                if(didAdd == false)
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
