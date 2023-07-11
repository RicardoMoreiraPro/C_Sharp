using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Argumentos_de_entrada_do_programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0) {
                Console.WriteLine("Quatidade de argumentos {0}",args.Length);
                for (int i =0; i < args.Length; i++)
                {
                    Console.WriteLine("Argumento {0}: {1}",i,args[i]);
                }
            }
            else
            {
                Console.WriteLine("Não foram passados argumentos");
            }
            Console.ReadLine();
        }
    }
}
