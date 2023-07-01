using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador() {
        Console.WriteLine("Jogador {0} destruido", nome);
        Console.ReadLine();
    }
}

namespace _23_construtores_e_destrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            Console.WriteLine("Digite o nome do jogador 1: ");
            nome1 = Console.ReadLine();
            Jogador j1 = new Jogador(nome1);
            Jogador j2 = new Jogador("Ricardo");
            Jogador j3 = new Jogador("Fernando");

            j1.energia = 50;
            Console.WriteLine("Energia do {1}: {0}", j1.energia, j1.nome);
            Console.WriteLine("Energia do {1}: {0}", j2.energia, j2.nome);
            Console.ReadLine();
        }
    }
}
