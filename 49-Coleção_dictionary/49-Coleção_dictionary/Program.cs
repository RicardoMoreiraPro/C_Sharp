using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Coleção_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int, string> //int = chave  string = valor/elemento
            Veiculos = new Dictionary<int, string> ();
            Veiculos.Add(10, "Carro");
            Veiculos.Add(5, "Avião");
            Veiculos.Add(0, "Navio");
            Veiculos.Add(20, "Moto");
            Veiculos.Add(15, "Patinete");

            //Veiculos.Clear();   para limpar o dictionary
            Veiculos.Remove(10);   //Para remover um valor
            Console.WriteLine("Tamanho do Dictionary: {0}", Veiculos.Count); //retorna quantos valores há na coleção
            int chave = 20;
            if (Veiculos.ContainsKey(chave))  //verifica se a chave está na coleção
            {
                Console.WriteLine("A chave {0} está na coleção", chave);
            }
            else
            {
                Console.WriteLine("A chave {0} não está na coleção", chave);
            }

            string valor = "Navio";
            if (Veiculos.ContainsValue(valor))  //verifica se o valor está na coleção
            {
                Console.WriteLine("O valor {0} está na coleção", valor);
            }
            else
            {
                Console.WriteLine("O valor {0} não está na coleção", valor);
            }
            Veiculos[15] = "Bicicleta";     //Para alterar um valor
            Console.WriteLine(Veiculos[15]);
            Console.WriteLine("-------------------");

            //Dictionary<int, string>.ValueCollection valores = Veiculos.Values; ou abaixo KeyValuePair
            foreach(KeyValuePair<int,string> v in Veiculos)
            {
                Console.WriteLine (v);   //(v.Value) ou (v.Key) para imprimir somente o valor ou chave
            }
            Console.ReadLine();

        }
    }
}
