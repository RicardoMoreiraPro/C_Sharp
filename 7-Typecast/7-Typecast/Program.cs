using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Typecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1 = 10.5f;
            int n2 = (int)n1;

            Console.WriteLine(n2);
            Console.ReadLine();

            int vInt = 20;
            short vShort = (short)vInt;

            Console.WriteLine(vShort);
            Console.ReadLine();

        }
    }
}
