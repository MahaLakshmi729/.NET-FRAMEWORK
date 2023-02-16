using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dynamicOperationsEx
{
public class program
    {
        public dynamic method1(dynamic dvar)
        {
            dynamic dynvar = "this is a local variable";
            int num = 10;
            if (dvar is int)
            {
                return dynvar;
            }
            else
                return num;
        }
        public static void Main(string[] args)
        {
            program obj=new program();
                Console.WriteLine(obj.method1(20));
                Console.WriteLine(obj.method1("dynamic value"));
                dynamic dynObj = new program();
                Console.WriteLine(dynObj.method1(25));
                Console.ReadLine();
        }
    }
}