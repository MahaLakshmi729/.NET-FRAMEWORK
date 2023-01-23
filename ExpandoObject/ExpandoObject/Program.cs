using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;
public class Program
{
    public static void Main(string[] args)
    {
        dynamic son, father;
        son = new ExpandoObject();
        son.Name = "son";
        son.Age = 18;
        father = new ExpandoObject();
        father.Name = "father";
        father.Age = 45;
        father.Children = 2;
        WriteFamily(father);
        WriteFamily(son);
        Console.WriteLine("\n");
        Console.WriteLine("Press enter to quit...");
        Console.Read();
    }
    private static void WriteFamily(dynamic member)
    {
        Console.WriteLine("{0} is {1} years old.", member.Name, member.Age);
    }
}
