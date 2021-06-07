using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary1
{
    public class ClsMaths
    { 
        //add method
        public int Addnumbers(int number1, int number2,int number3)
        {
            int result = number1 + number2 + number3;
            return result;

        }

        //sub method
        public int SubtractNumbers(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }

        //multiplication meyhod
        public long MultiNumbers(int number1, int number2)
        {
            long result = number1 * number2;
            return result;

        }

        //div method
        public long DivNumbers(int number1, int number2)
        {
            long result = number1 / number2;
            return result;
        }
    }
}
