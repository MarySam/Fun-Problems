using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntParseMethod
{
    class Program
    {

        public static int Parse(string s)
        {
            int result = 0;
            for(int i=0; i<s.Length; i++)
            {
                int value = s[i] - '0';
                result *= 10;
                result += value;
            }

            return result;
        }

        static void Main(string[] args)
        {
            string s = "123";

            int after = Parse(s);

            Console.WriteLine("{0}", after);
            Console.ReadLine();
        }
    }
}
