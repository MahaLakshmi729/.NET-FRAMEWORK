using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace multidimensional
{
    class program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];
            Console.Write("enter value for the matrix[0,0] element: ");
            matrix[0, 0] = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value for the matrix[0,1] element: ");
            matrix[0, 1] = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value for the matrix[1,0] element: ");
            matrix[1, 0] = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value for the matrix[1,1] element: ");
            matrix[1, 1] = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the generated matrix is: ");
            Console.WriteLine("\t\t\t" + matrix[0,0]+" " + matrix[0,1]);
            Console.WriteLine("\t\t\t" + matrix[1,0] + " " + matrix[1,1]);
            Console.ReadLine();
        }

    }
}
