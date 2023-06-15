using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1,n2,n3,n4,n5;
            int[] n = new int[5];
            n[0] = 11;
            n[1] = 22;
            n[2] = 33;
            n[3] = 44;
            n[4] = 55;
            Console.WriteLine(n[0]);
            Console.ReadLine();

            int[] num = new int[3] {11,22,33};
            Console.WriteLine(num[1]);
            Console.ReadLine();

            int[] numero = { 11, 22, 33 }; //o tamanho do array é definido pela quantidade de elementos 
            Console.WriteLine(numero[2]);
            Console.ReadLine();
        }
    }
}
