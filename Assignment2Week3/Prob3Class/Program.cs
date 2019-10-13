using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 In Main() demonstrate:
    - the use of each constructor. Print the state as necessary to show behavior.
    - the use of the accessor and mutator for the name field
    - the use of the both properties
    - a try/catch block that demonstrates the exception that was coded into the ID property
    - use regions as you think appropriate.
 */
namespace Prob3Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // chaining, constructor overloading demo
            Console.WriteLine("====== CONSTRUCTORS DEMO ======");
            Console.WriteLine("VERSION ONE");
            Student newStudent1 = new Student();
            newStudent1.PrintState();
            Console.WriteLine();

            Console.WriteLine("VERSION TWO");
            Student newStudent2 = new Student("Louie Clark");
            newStudent2.PrintState();
            Console.WriteLine();

            Console.WriteLine("VERSION THREE");
            Student newStudent3 = new Student("Louie Clark", 999998, 4.00F);
            newStudent3.PrintState();
            Console.WriteLine();

            // use of accessor & mutator method for name field
            Console.WriteLine("====== ACCESSORS/MUTATORS DEMO ======");
            Console.WriteLine("Change student name from default: \"{0}\"\nto \"George\"", newStudent1.getStudentName());
            newStudent1.setStudentName("George");
            newStudent1.PrintState();
            Console.WriteLine();

            // Exceptions Demo
            Console.WriteLine("====== EXCEPTIONS DEMO ======");
            try
            {
                Student newStudent = new Student();
                newStudent.setStudentName("Regina");
                newStudent.StudentID = 321;
                newStudent.StudentGPA = 3.85;
                // both properties are used in code above
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            
            
            
        }
    }
}
