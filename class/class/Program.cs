using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace creatingobjects
{
    class class1
    {
        private int num1 = 24;
        private int num2 = 36;
        public void average()
        {
            int av = (num1 + num2) / 2;
            Console.WriteLine("average: " + av);

        }
        class program
        {
            static void Main(string[] args)
            {
                class1 obj=new class1();
                obj.average();
                Console.ReadLine();
            }
        }
    }

}

