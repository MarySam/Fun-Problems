using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Missing_Parens
//Problem:  Find the missing parens in the given expression.
//Solution: Iterate through the expression using a forloop and store the paren counts in two variables.
//Efficiency: O(n).

{
    class Program
    {
        public static void MissParens(string Expression)
        {
            int openParens = 0;
            int closeParens = 0;
            int i = 0;
            while (i < Expression.Length)
            {
                if (Expression[i] == '(')
                {
                    openParens = openParens + 1;
                }
                if (Expression[i] == ')')
                {
                    closeParens = closeParens + 1;
                }
                i++;
            }

            if (openParens > closeParens)
            {
                int diff = openParens - closeParens;
                Console.WriteLine("We are missing {0} closeParens", diff);
            }

            if (openParens < closeParens)
            {
                int diff = closeParens - openParens;
                Console.WriteLine("We are missing {0} openParens", diff);
            }

            if (openParens == closeParens)
            {
                Console.WriteLine("We are not missing any parens");
            }

        }

        static void Main(string[] args)
        {
            string Expression = "((2*(3+4)*(5+6))";
            MissParens(Expression);
            Console.ReadLine();
        }
    }
}

