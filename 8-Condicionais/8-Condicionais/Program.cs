using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4,res;
            Console.WriteLine("Insira a nota 1:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a nota 2:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a nota 3:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a nota 4:");
            n4 = int.Parse(Console.ReadLine());
            string resultado;
            res=n1+n2+n3+n4;
            if (res >= 60)
            {
                if (res >= 90)
                {
                    if (res == 100)
                    {
                        resultado = "Aprovado com super louvor";
                    }
                    else
                    {
                        resultado = "Aprovado com louvor";
                    }
                    
                }
                else
                {
                    resultado = "Aprovado";
                }
            }else if (res >=40)
            {
                resultado = "Em Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
            Console.WriteLine("Nota: {0} \nResultado: {1}", res, resultado);
            Console.ReadLine();
        }
    }
}
