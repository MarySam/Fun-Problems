using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Unique_Value_in_an_Array_of_Duplicates
//SORTED ARRAY
//Assumptions:  The array contains only one unique value where all other elements appear twice on after another.
//Solution: A for loop where we increment by 2 and compare the value at index i to index i+1. 
//Efficiency: O(n).

{
    class Program
    {
        static void Main(string[] args)
        {
            //Given
            int[] array1 = new int[] { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };

            for (int i = 0; i < array1.Length; i = i + 2)
            {
                //Here we are comparing the value at index i to the value at index i+1.
                if (array1[i] != array1[i + 1])
                {
                    Console.WriteLine("The unique value is {0}", array1[i]);
                    Console.ReadLine();
                }
            }
        }
    }
}

//We can compare in pairs since the duplicate will be right next to each other.
