using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Veiculo    //Classe base
{
    public int rodas;
    public int velMax;    //Membro, propriedade
    private bool ligado;   //Membro, propriedade

    public void ligar()   //Método
    {
        ligado = true;
    }
    public void desligar()   //Método
    {
        ligado = false;
    }
    public string getLigado()
    {
        if (ligado)
        {
            return "Sim";
        }
        else
        {
            return "Não";
        }
    }
}

class Carro : Veiculo    //A classe derivada, herda a classe base
{
    public string nome;        //Membro, propriedade
    public string cor;         //Membro, propriedade
    public Carro(string nome, string cor /*Parâmetros*/)      //Construtor
    {
        ligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

namespace _28_Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapidão","Verde");

            Console.WriteLine("Nome.........: {0}", c1.nome);
            Console.WriteLine("Cor..........: {0}", c1.cor);
            Console.WriteLine("Rodas........: {0}", c1.rodas);
            Console.WriteLine("Vel Máxima...: {0}", c1.velMax);
            Console.WriteLine("Ligado.......: {0}", c1.getLigado());
            Console.ReadLine();
        }
    }
}
