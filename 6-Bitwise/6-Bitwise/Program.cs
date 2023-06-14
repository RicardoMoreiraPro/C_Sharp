using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para a esquerda << dobro
            //Para a direita >> metade

            int num = 20;
            num = num >> 1;
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
