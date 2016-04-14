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
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter an expression");
            //string expression = Console.ReadLine();

            string expression = "((2*(3+4)*(5+6))";
            int openParens = 0;
            int closeParens = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openParens = openParens + 1;
                }

                if (expression[i] == ')')
                {
                    closeParens = closeParens + 1;
                }

            }

            Console.WriteLine("openParens: {0} closeParens: {1}", openParens, closeParens);

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

            Console.ReadLine();
        }
    }
}

