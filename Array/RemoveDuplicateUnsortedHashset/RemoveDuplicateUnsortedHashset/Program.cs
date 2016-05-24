using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateUnsortedHashset
{
    class Program
    {

        public static HashSet<int> RemoveDuplicates (int[] A)
        {
            HashSet<int> HashA = new HashSet<int>();
            HashSet<int> HashB = new HashSet<int>();

            for (int i = 0; i<A.Length; i++)
            {
                bool result = HashA.Add(A[i]);

                if(result==false)
                {
                    HashB.Add(A[i]);  
                }
            }

            return HashB;

        }
        static void Main(string[] args)
        {

            int[] A = new int[] { 7, 7, 1, 5, 8, 8, 2 };
            HashSet<int> HashB = new HashSet<int>();
            HashB = RemoveDuplicates(A);

            foreach (int v in HashB)
            {
                Console.WriteLine("{0}", v);
                Console.ReadLine();
            }
        }
    }
}
