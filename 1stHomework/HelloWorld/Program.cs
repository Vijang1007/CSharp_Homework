using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            string s1, s2;
            System.Console.Write("input s1 :");
            s1 = System.Console.ReadLine();
            System.Console.Write("input s2 :");
            s2 = System.Console.ReadLine();
            System.Console.WriteLine($"the string is\n{s1}, {s2}");
            System.Console.WriteLine("the string is\n{0}, {1}", s1, s2);
            string message;
            message = s1 + ", " + s2;
            System.Console.WriteLine("the string is\n{0}", message);
            System.Console.WriteLine($"the string is\n{message}");
            System.Console.ReadKey();
        }
    }
}
