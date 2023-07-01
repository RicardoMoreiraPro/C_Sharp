using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    static public void info()
    {
        Console.WriteLine("Nome do jogador.....: {0}", nome);
        Console.WriteLine("Energia do jogador..: {0}", energia);
        Console.WriteLine("Estado do jogador...: {0}\n", vivo);
    }

}

class Inimigo
{
    static public bool alerta;
    public string nome;
    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }
    public void info()
    {
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("----------------------");
    }
}

namespace _23_construtores_e_destrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador.iniciar("Ricardo");
            Jogador.info();
            Console.ReadLine();

            Inimigo i1 = new Inimigo("Doido");
            Inimigo i2 = new Inimigo("Maluco");
            Inimigo i3 = new Inimigo("Pirado");

            
            i1.info();
            i2.info();
            i3.info();
            Inimigo.alerta = true;
            i1.info();
            i2.info();
            i3.info();
            Console.ReadLine() ;
        }
    }
}
