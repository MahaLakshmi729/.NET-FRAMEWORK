using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace structure
{
    public struct x
    {
        public int a, b, c;
    }
    class program
    {
        static void Main(string[] args)
        {
            x x1=new x();
            x1.a = 1;   
            x1.b = 2;
            x1.c = 3;
            Console.WriteLine("data of the X1 object:");
            Console.WriteLine("a= " + x1.a);
            Console.WriteLine("b= " + x1.b);
            Console.WriteLine("c= " + x1.c);
            x x2=new x();
            Console.WriteLine("data of the X2 object:");
            Console.WriteLine("a= " + x2.a);
            Console.WriteLine("b= " + x2.b);
            Console.WriteLine("c= " + x2.c);

        }
    }
}