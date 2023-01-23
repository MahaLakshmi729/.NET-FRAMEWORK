using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;
namespace operators
{
    class program
    {
        static void Main(string[] args) 
        { 
            int num1=20, num2=8, result1,result2,result3,result4;
            result1=num1+num2;
            Console.WriteLine("result1= "+result1);
            result2 = num1 - num2;
            Console.WriteLine("result2= " + result2);
            result3 = -1*2+3*4-5;
            Console.WriteLine("result3= " + result3);
            result4 = ((-1 * 2) + 3) * (4 - 5);
            Console.WriteLine("result4= " + result4);
            Console.ReadLine();

        }
    }
}