using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace constructorsanddestructors
{
    class rectangle
    {
        int length,width;
        public rectangle(int x, int y)
        {
            length = x;
            width = y;
        }
        rectangle()
        {
            Console.WriteLine("finalizing rectangle..");
            Console.ReadLine();
        }
        public void area()
        {
            Console.WriteLine("area of the triangle:" + length * width);
        }
     }
    class program
    {
        static void Main(string[] args) 
        {
            rectangle rect = new rectangle(30, 20);
            rect.area();
        }
    }
}

