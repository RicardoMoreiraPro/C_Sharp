using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i = 0;
            while (i<num.Length)
            {
                num[i] = i;
                Console.WriteLine(num[i]);
                i++;                
            }

            Console.WriteLine("Fim");
            Console.ReadLine();

        }
    }
}
