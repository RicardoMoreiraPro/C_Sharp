using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha");
                senhauser = Console.ReadLine();
                tentativas++;
            }while(senha != senhauser);
            Console.WriteLine("Senha correta!\nTentativas: {0}", tentativas);
            Console.ReadLine();


            int num = 5;
            while (num < 5)
            {
                Console.WriteLine("Ricardo1");
            }

            do{
                Console.WriteLine("Ricardo2");
            }while (num < 5);

            Console.ReadLine();
        }
    }
}
