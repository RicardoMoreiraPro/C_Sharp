using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Metodos_Passage_por_valor_e_referencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar(ref num);
            Console.WriteLine(num);
            Console.ReadLine();
        }

        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}
