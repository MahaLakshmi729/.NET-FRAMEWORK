using System;
namespace FunctionExample
{
    class Program
    {
        
        public void Show(string message)
        {
            Console.WriteLine("Hello " + message);
            
        }
        
        static void Main(string[] args)
        {
            Program program = new Program(); 
            program.Show("Mohammed anas"); 
        }
    }
}