using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
In Main() create the following
region 1: array of strings
    - create an array of strings of the first ten whole numbers 
      (e.g. "one", "two", . . . "ten")
    - Initialize the array using initialization syntax
    - print the array using a foreach loop
region 2: array of ints
    - create an array of ints of size 10
    - Initialize the array using a for loop with values being the index multiplied 
      by 10
    - print the array using a for loop
region 3: 2-D array
    - create a 2-D array that will hold the values of the multiplication table 
      up to 12 x 12
    - Initialize the array
    - print the array in a well formatted manner
    bonus points for labeling the rows and columns
 */

namespace Assignment2Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays of Strings
            Console.WriteLine("*** REGION ONE: Arrays of Strings ***\n");
            // create an array of strings
            // initialize array by new keyword and filling in values
            string[] strArray = new string[] {"one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine", "ten" };
            // print each element of array using a foreach loop
            foreach(string element in strArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("\n*** End of Region One ***\n");
            #endregion



            #region Arrays of Ints
            Console.WriteLine("*** REGION TWO: Arrays of Ints ***\n");
            // create an array of ints of size 10
            int[] intArray = new int[10];
            // initialize array using a for loop with values being the index
            // multiplied by 10
            for(int i = 0; i < intArray.Length; i++)
            {
                // print the array using a for loop
                Console.WriteLine(intArray[i] = i * 10);
            }
            Console.WriteLine("\n*** End of Region Two ***\n");
            #endregion



            #region 2-D Array
            Console.WriteLine("*** REGION THREE: 2-D Array ***\n");
            // create a 2-D array that will hold values of a multiplication table
            // up to 12 x 12
            int[,] multTable = new int[13, 13];
            // initialize the array
            for(int y = 1; y <= 12; y++)
            {
                Console.WriteLine();
                for(int x = 1; x <= 12; x++)
                {
                    // print the array in a well-formatted manner
                    Console.Write("{0}\t", multTable[x, y] = x * y); 
                }
                // Console.WriteLine(); // optional line if you want to space the numbers further
            }
            Console.WriteLine();
            Console.WriteLine("\n*** End of Region Three ***\n");
            #endregion
        }
    }
}
