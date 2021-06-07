using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Student 
    {
        //variable
        public int StudentId;

        public string StudentName;

        //constructor 
        public Student()
        {
            StudentId = 0;
            StudentName = "Vasanth";

        }
        //Method or function or member function
        //Access Specifier 
        //DataType(output) MethodName((Input) datatype(parameter1), datatype(parameter2)) { }

        public int AddMarks(int mark1,int mark2)
        {
            int result = mark1 + mark2;
            return result;

        }
    }
}
