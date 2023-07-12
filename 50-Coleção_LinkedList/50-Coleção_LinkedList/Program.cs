using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Coleção_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> transp = new LinkedList<string>();

            transp.AddFirst("Carro");   //adiciona no inicio da lista
            transp.AddFirst("Aviao");
            transp.AddFirst("Navio");
            transp.AddFirst("Motocicleta");
            transp.AddLast("Bicicleta");    //adiciona no final da lista
            LinkedListNode<string>no;
            no = transp.FindLast("Navio");
            transp.AddAfter(no,"Patinete");     //adiciona após de um determinado elemento
            transp.AddBefore(no, "Patins");     //adiciona antes de um determinado elemento
            //transp.Clear();  //remove todos os elementos
            
            foreach (string t in transp)
            {
                Console.WriteLine("Transporte: {0}",t);
            }

            if (transp.Find("Carro") == null)   //verifica se o valor há na lista
            {
                Console.WriteLine("Não encontrado");
            }
            else
            {
                Console.WriteLine("O elemento foi encontrado");
            }
            transp.Remove("Navio");    //Para remover um elemento
            transp.RemoveFirst();  //Remove o primeiro elemento
            transp.RemoveLast();   //Remove o ultimo elemento
            foreach (string t in transp)
            {
                Console.WriteLine("Transporte: {0}", t);
            }
            Console.ReadLine();
        }
    }
}
