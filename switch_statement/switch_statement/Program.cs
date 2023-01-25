using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace switchstatement
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a vowel: ");
            char mychar=Convert.ToChar(Console.ReadLine());
            char x= char.ToUpper(mychar);
            switch(x)
            {
                case 'A':
                    Console.WriteLine("the entered vowel is: A");
                    break;
                case 'E':
                    Console.WriteLine("the entered vowel is: E");
                    break;
                case 'I':
                    Console.WriteLine("the entered vowel is: I");
                    break;
                case 'O':
                    Console.WriteLine("the entered vowel is: O");
                    break;
                case 'U':
                    Console.WriteLine("the entered vowel is: U");
                    break;
                    default:
                    Console.WriteLine("the entered charcter is not a vowel:");
                    break;
            }
            Console.ReadLine();
        }
    }
}
