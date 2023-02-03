using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace methodoverriding
{
    public class animal
    {
        public virtual void sleep()
        {
            Console.WriteLine("the animal is sleeping....");
        }
    }
    public class dog : animal 
    {
        public override void sleep()
        {
            Console.WriteLine($"the dog is sleeping.....");
        }

    }
    class program
    {
        static void Main(string[] args) 
        {
            animal a = new animal();
            a.sleep();
            dog d = new dog();
            d.sleep();
            Console.ReadLine();
        }
    }
}
