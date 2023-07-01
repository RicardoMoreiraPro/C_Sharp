using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cfb();


            int v1,v2;
            Console.WriteLine("Digite 2 valores");
            v1=Convert.ToInt32(Console.ReadLine());
            v2=int.Parse(Console.ReadLine()); 
            soma(v1 ,v2);


            int v3, v4, r;
            Console.WriteLine("Digite outos 2 valores");
            v3 = Convert.ToInt32(Console.ReadLine());
            v4 = int.Parse(Console.ReadLine());
            r = soma2(v3,v4);
            Console.WriteLine("A soma de {0} e {1} é: {2}", v3, v4, r);
            Console.ReadLine();
        }

        static void cfb() //void não retorna nada
        {
            Console.WriteLine("Ricardo");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("No youtube");
            Console.ReadLine();
        }

        static void soma(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("A soma de {0} e {1} é: {2}",n1,n2,res);
            Console.ReadLine() ;
        }

        static int soma2(int n3, int n4)
        {
            int resultado = n3 + n4;
            return resultado;
        }
    }
}
