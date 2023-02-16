using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dynamicType
{
    class Program
    {
        static dynamic dyn = 5.56;
        public void method1(string str,int b)
        {
            Console.WriteLine(str);
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.method1("hello", 45);
            dyn = "welcome";
            p.method1(dyn, 56);
            Console.Read();
        }
    }
}