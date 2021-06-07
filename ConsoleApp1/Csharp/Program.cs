using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary1;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////boxing - v2r
            ////value type 
            //int num = 100;

            ////refernce type-object or string
            //Object obj = num;
            //Console.WriteLine("value after conversion " + obj);
            //Console.ReadLine();
            ////unboxing -r2v
            //Object rObj = 23432;
            //int studInt = (int)rObj;
            //Console.WriteLine("value after conversion " + studInt);
            //Console.ReadLine();


            //Student student = new Student();
            //student.StudentId = 00120;
            //student.StudentName = "Julie";

            //int res = student.AddMarks(95, 96);

            //ClsMaths clsMaths = new ClsMaths();
            //int addRes = clsMaths.Addnumbers(56, 64, 98);
            //Console.WriteLine("Addition :" + addRes);


            //int subRes = clsMaths.SubtractNumbers(5634, 4523);
            //Console.WriteLine("Subtraction :" + subRes);

            //long mulRes = clsMaths.MultiNumbers(200, 300);
            //Console.WriteLine("Multiplication :" + mulRes);

            //long divRes = clsMaths.DivNumbers(400 , 200);
            //Console.WriteLine("division :" + divRes);
            //Console.ReadLine();
            //int goodnum1 = 0;
            //int goodnum2 = 0;
            //Collectnumber1:
            //Console.WriteLine("Enter number1: ");
            //var num1 = Console.ReadLine();

            //if(num1=="")
            //{
            //    Console.WriteLine("User pls enter a proper value");
            //    goto Collectnumber1;

            //}
            //else
            //{
            //    goodnum1 = Convert.ToInt32(num1);
            //}
            //Getnumber2:
            //Console.WriteLine("Enter number2: ");
            //var num2 = Console.ReadLine();

            //if(num2=="")
            //{
            //    Console.WriteLine("User pls enter a proper value");
            //    goto Getnumber2;
            //}
            //else
            //{
            //    goodnum2 = Convert.ToInt32(num2); //if not converted then it will consider as string and will concatenate
            //}
            //var res = goodnum1 + goodnum2;
            //Console.WriteLine(res);
            //Console.ReadLine();

            long total = 0;
            for(int count = 0; count<5; count++ )
            {
                Console.WriteLine("Enter marks" + count);
                int mark = Convert.ToInt32(Console.ReadLine());
                total = total + mark;
            }
            Console.WriteLine("Total marks:" +total);
            Console.ReadLine();



        }
    }
}
