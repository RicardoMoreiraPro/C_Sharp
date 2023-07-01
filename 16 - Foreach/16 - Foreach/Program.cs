using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 11, 22, 33, 44, 55 };

            foreach(int n in num)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();


          /*for (int i=0;i<num.Length;i++)
            {
                Console.WriteLine(num[i]);      
            }
            Console.ReadLine();*/
        }
    }
}
