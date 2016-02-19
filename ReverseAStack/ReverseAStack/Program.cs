using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAStack
//Problem:  Reverse a stack and put the reversed value back in the same stack. 
//          You can use only one other stack and a temp variable.
//Solution:  One outer for loop and 2 inner for loops.
//Efficiency: O(n^2).

{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            int tempVariable = 0;

            for (int i = 1; i <= 10; i++)
            {
                stack1.Push(i);
            }

            Console.WriteLine("Before");
            Console.Write(GetStackString(stack1));
            Console.ReadLine();

            int n = stack1.Count;

            for (int i = 1; i<=n; i++)
            {
                tempVariable = stack1.Pop();

                //Move stack1 to stack2
                for (int x = 1; x <= n - i; x++)
                {
                    stack2.Push(stack1.Pop());
                }

                stack1.Push(tempVariable);

                //Move stack2 to stack1
                for (int x = 1; x <= n - i; x++)
                {
                    stack1.Push(stack2.Pop());
                }
            }

            Console.WriteLine("After");
            Console.Write(GetStackString(stack1));
            Console.ReadLine();
        }

        private static string GetStackString(Stack<int> stack)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int value in stack)
            {
                sb.AppendLine(value.ToString());
            }

            return sb.ToString();
        }
    }
}

//Pop the top value from stack1 into the temp variable.  
//Pop the remaining values (n-1) and push into stack2.
//Push the value from the temp variable into stack1.
//Pop all values from stack2 (n-1) and push back into stack1.
//Pop the top value from stack1 into the temp variable.
//Pop the remaining values (n-2) from stack1 and push into stack2.
//Push the value from the temp variable into stack1.
//Pop all values from stack2 (n-2) and push back into stack1.
//Repeat until complete.










