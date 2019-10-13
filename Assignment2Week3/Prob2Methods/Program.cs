using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create a static method that demonstrates call by value. Add print statements that 
will help demonstrate this concept.

Create a static method that demonstrates call by reference. Add print statements that
will help demonstrate this concept.

Create static methods that demonstrate method overloading
In Main() create the following
    region 1: demo of call by value
        Code that will demonstrate call by value
    region 2: demo of call by reference
        code that will demonstrate call by reference
    region 3: overloading
        code that demonstrates method overloading
 */

namespace Prob2Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region demo of call by value
            Console.WriteLine("=== DEMO OF CALL BY VALUE ===\n");
            // initialize a variable
            int myInt = 16;
            Console.WriteLine("Before Method Call:\t{0}\n", myInt);
            // call method
            ValueDemo(myInt);
            Console.WriteLine("After Method Call:\t{0}\n", myInt);
            Console.WriteLine("=============================\n");
            #endregion


            #region demo of call by reference
            Console.WriteLine("= DEMO OF CALL BY REFERENCE =\n");
            // create and initialize an array
            int[] intArray = new int[] { 10, 20, 30, 40, 50 };
            // print array values
            Console.WriteLine("Before Method Call:");
            foreach(int num in intArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            // call method
            ReferenceDemo(intArray);
            // print values again
            Console.WriteLine();
            Console.WriteLine("After Method Call:");
            foreach (int num in intArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("=============================\n");
            #endregion


            #region overloading
            Console.WriteLine("==== DEMO OF OVERLOADING ====\n");
            // print current values of already defined int array
            Console.WriteLine("Current Values of Array:");
            foreach (int num in intArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
            // call overloaded method
            ValueDemo(intArray);
            // print new values
            Console.WriteLine("New Values of Array:");
            foreach (int num in intArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("=============================\n");
            #endregion
        }



        #region methods
        // create a static method that demos call by value
        static void ValueDemo(int arg)
        {
            arg = 49;
            Console.WriteLine("Within Method:\t\t{0}\n", arg);
        }

        // method for overloading demo
        static void ValueDemo(int[] arg2)
        {
            arg2[0] = 4;
        }


        // create a static method that demos call by reference
        static void ReferenceDemo(int[] arg1)
        {
            arg1[3] = 16;
            Console.WriteLine("\nWithin Method:");
            foreach (int num in arg1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
           
        }
        #endregion
    }
}
