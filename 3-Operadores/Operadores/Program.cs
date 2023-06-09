using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores relacionais >, <, >=, <=, !=
            //Operadores de incremento +=1 ou ++
            //Operadores de decremento -=1 ou ++
            //Operadores logicos & = And, | = OR

            int res = (10 + 5) * 2;
            Console.WriteLine(res);
            Console.ReadLine();

            bool res2 = (10 > 5) | (12 < 6); //TRUE OR FALSE
            Console.WriteLine(res2);
            Console.ReadLine();
        }
    }
}
