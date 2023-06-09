using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 10; //0 e 255
            int num = 0;
            char letra = 'a';
            float valor = 5.3f;
            string palavra = "ricardo";

            var aux = 10;

            int num1, num2, res;

            num1 = 10;
            num2 = 20;
            res = num1 + num2;

            

            Console.WriteLine("Valor da variavel:" + valor);
            Console.ReadLine();
            Console.WriteLine("A soma de " + num1 + " mais " + num2 + " É igual a " + res);
            Console.ReadLine();

        }
    }
}
