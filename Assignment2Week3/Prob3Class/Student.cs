using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Create a "Student" class:
    - create a name filed and the associated set and get methods
    - create a ID property. Add validation code to the set method that ensures the value 
        is between 100000 and 999999. Throw an exception if the value is out of range.
    - create an automatic property for GPA. Pick an appropriate type.
    - create a master constructor that has parameters for all three internal data 
        elements
    - create a constructor that has parameters for name and ID and uses chaining
    - create a default constructor
    - code a "PrintState()" method
 */

namespace Prob3Class
{
    class Student
    {
        #region internal class data
        // field
        private string studentName;
        // these methods provides access to the private field above
        public string getStudentName() { return studentName; }
        public void setStudentName(string name) 
        {
            studentName = name;
        }

        // property
        // must set a private data field for this property to access
        private int id;
        public int StudentID
        {
            get
            { return id; }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    // throw an exception
                    throw new Exception("Invalid ID value provided");
                }
                else id = value;
            }
        }
        // auto property
        public double StudentGPA { get; set; }
        #endregion



        #region constructors
        // master constructor
        public Student(string stuName, int StuID, float StuGPA)
        {
            // field = parameter
            studentName = stuName;
            StudentID = StuID;
            StudentGPA = StuGPA;
        }

        // other constructors
        public Student() : this("none", 999999, 0) { }
        public Student(string stuName) : this(stuName, 999999, 0) { }
        #endregion

       
        #region PrintState() method
        public void PrintState()
        {
            // print name
            Console.WriteLine("Name:\t{0}", getStudentName());
            // print SID
            Console.WriteLine("S.I.D:\t{0}", StudentID);
            // print GPA
            Console.WriteLine("GPA:\t{0}", StudentGPA);
        }
        #endregion
    }

}

