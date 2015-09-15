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

            int sum = 0;
            foreach (string valueTyped in input)
            {
                int conversion = int.Parse(valueTyped);

                int[] arr = new int[] { conversion };
                
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine(sum);
                Console.ReadLine();

            }

        }
    }
}
