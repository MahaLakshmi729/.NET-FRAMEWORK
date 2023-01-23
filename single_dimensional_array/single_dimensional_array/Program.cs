using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
namespace singledimensionalarrays
{
    class program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[3];
            int totalmarks = 0;
            Console.Write("enter the marks in subject A: ");
            marks[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the marks in subject B: ");
            marks[1] = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("enter the marks in subject C: ");
            marks[2] = Convert.ToInt32(Console.ReadLine());
            totalmarks = marks[0]+ marks[1]+ marks[2];
            Console.Write("total marks: " + totalmarks);
            Console.ReadLine();
        }
    }
}