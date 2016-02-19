using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingParens_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            char[] expression = new char[] { '(', '2', '*', '(', '3', '+', '4', ')', '*', '(', '5', '+', '6', ')', ')' };

            int openParens = 0;
            int closeParens = 0;


            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack1.Push(expression[i]);
                }

                if (expression[i] == ')')
                {
                    stack2.Push(expression[i]);
                }

                openParens = stack1.Count;
                closeParens = stack2.Count;
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

