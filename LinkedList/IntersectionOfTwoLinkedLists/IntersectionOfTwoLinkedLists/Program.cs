using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoLinkedLists
{
    class Program
    {
        public static Node Intersection(LinkedList ListA, LinkedList ListB)
        {
            HashSet<Node> myHash = new HashSet<Node>();

            Node currA = ListA.Head;
            while(currA!=null)
            {
                myHash.Add(currA);
                currA = currA.Next;
            }

            Node currB = ListB.Head;
            while(currB!=null)
            {
                if(myHash.Contains(currB))
                {
                    return currB;
                }

                currB = currB.Next;
            }

            return null;
        }

        static void Main(string[] args)
        {
        }
    }
}
