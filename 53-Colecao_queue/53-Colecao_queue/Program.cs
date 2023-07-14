using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Colecao_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] vs = { "Carro", "Moto", "Navio", "Avião" };
            Queue<string> veiculos = new Queue<string>(/*vs*/);
            veiculos.Enqueue("Carro");    //Adiciona do final da fila
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Avião");
            Console.WriteLine("Tamanho fila: " + veiculos.Count);
            foreach (string l in veiculos)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("------------------");
            string v = "Avião";
            if(veiculos.Contains(v))
            {
                Console.WriteLine("Veiculo " + v + " encontrado");
            }
            else
            {
                Console.WriteLine("Veiculo " + v + " não encontrado");
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());   //Retorna o primeiro elemento e remove
            Console.WriteLine("Primeiro veiculo " + veiculos.Peek());   //Retorna o primeiro elemento e não remove
            foreach (string l in veiculos)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("------------------");
            while(veiculos.Count > 0)
            {
                Console.WriteLine(veiculos.Dequeue());    //removerá um por um
            }
            Console.WriteLine("Tamanho fila: " + veiculos.Count);
            Console.ReadLine();
        }
    }
}
