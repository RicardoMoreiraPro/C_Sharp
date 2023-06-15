using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int num=0;num<10;num++)
            {
                Console.WriteLine(num + "º repetição");
            }
            Console.ReadLine();

            int[] n = new int[10];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = i*2;
                Console.WriteLine("Valor da n na pos {0}: {1}", i, n[i]);
            }
            Console.ReadLine();

        }
    }
}
