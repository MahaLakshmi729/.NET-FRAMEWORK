using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;
namespace functionexample
{
    class program
    {
        public void show(string message)
        {
            Console.WriteLine("hello" + message);
        }
        static void Main(string[] args)
        {
            program program = new program();
            program.show("world");
        }
    }
}