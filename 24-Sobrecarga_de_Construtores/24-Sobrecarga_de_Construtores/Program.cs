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

    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e, bool v)
    {
        energia = e;
        vivo = v;
        nome = n;
    }
    public void info()
    {
        Console.WriteLine("Nome do jogador.....: {0}", nome);
        Console.WriteLine("Energia do jogador..: {0}", energia);
        Console.WriteLine("Estado do jogador...: {0}\n", vivo);
    }

}

namespace _23_construtores_e_destrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Ricardo");
            Jogador j3 = new Jogador("Fernando", 90);
            Jogador j4 = new Jogador("Benegundesfirno", 0, false);

            j1.info();
            j2.info();
            j3.info();
            j4.info();
            Console.ReadLine();
        }
    }
}
