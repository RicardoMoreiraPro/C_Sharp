using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mat
{
    public static double pi = 3.14;
    public static int dobro(int n)
    {
        return n * 2;
    }
}

namespace _43_Metodos_e_variaveis_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vpi = Mat.pi;
            int num = 10;
            Console.WriteLine(Mat.dobro(num));
            Console.WriteLine(vpi);
            Console.ReadLine();
        }
    }
}
