using System;
using static System.Console;
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
            string sA;
            sA = ReadLine();

            int nA;
            nA = Convert.ToInt32(sA);
            WriteLine(nA);

            float fA;
            fA = (float)nA;
            WriteLine(fA);

            sA = Convert.ToString(fA);
            WriteLine(sA);

            System.Console.ReadKey();
        }
    }
}
