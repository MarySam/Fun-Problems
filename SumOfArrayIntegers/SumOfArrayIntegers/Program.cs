using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArrayIntegers
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What numbers would you like to add?\nPlease separate each number with a comma");
            string UserValue = Console.ReadLine();

            Console.WriteLine("You typed " + UserValue);
            Console.ReadLine();

            string[] delimiterString = { "," };

            string[] input = UserValue.Split(delimiterString, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0} numbers were typed in:", input.Length);

            // While Loop
            //int sum = 0;
            //int i = 0;
            //while (i < input.Length)
            //{
            //    string valueTyped = input[i];

            //    int conversion = int.Parse(valueTyped);
            //    sum += conversion;

            //    i++;
            //}

            // For Loop
            //int sum = 0;
            //for (int x = 0; x < input.Length; x++)
            //{
            //    string valueTyped = input[x];

            //    int conversion = int.Parse(valueTyped);
            //    sum += conversion;
            //}

            // Foreach Loop
            int sum = 0;
            foreach (string valueTyped in input)
            {
                int conversion = int.Parse(valueTyped);
                sum += conversion;

                ///ShortCut: sum+=int.Parse(valueTyped); 
            }

            Console.WriteLine("Your sum is " + sum);
            Console.ReadLine();

        }

    }

}
