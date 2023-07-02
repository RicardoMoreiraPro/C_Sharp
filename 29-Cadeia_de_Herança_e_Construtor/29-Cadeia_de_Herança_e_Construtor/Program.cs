using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Veiculo    //Classe base
{
    private int rodas;    //Membro, propriedade
    public int velMax;    //Membro, propriedade
    private bool ligado;  //Membro, propriedade

    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }
    public void ligar()   //Método
    {
        ligado = true;
    }
    public void desligar()   //Método
    {
        ligado = false;
    }
    public string getLigado()   //Método
    {
        return (ligado ? "Sim" : "Não");
        /*if (ligado)
        {
            return "Sim";
        }
        else
        {
            return "Não";
        }*/
    }
    public int getRodas()     //Método
    {
        return rodas;
    }
    public void setRodas(int rodas)
    {
        if (rodas < 0){
            this.rodas = 0;
        }else if(rodas > 40){
            this.rodas = 40;
        }
        else
        {
            this.rodas = rodas;
        }
    }
}

class Carro : Veiculo    //A classe derivada, herda a classe base
{
    public string nome;        //Membro, propriedade
    public string cor;         //Membro, propriedade
    public Carro(string nome, string cor /*Parâmetros*/): base(4)     /*Construtor inicializando
                                                                      o construtor da classe base*/
    {
        ligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate : Carro
{
    public int municao;
    public CarroCombate() : base("Carro de combate", "Vermelho")
    {
        municao = 100;
        setRodas(6);
    }
}

namespace _28_Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapidão", "Verde");
            Console.WriteLine("Nome.........: {0}", c1.nome);
            Console.WriteLine("Cor..........: {0}", c1.cor);
            Console.WriteLine("Rodas........: {0}", c1.getRodas());
            Console.WriteLine("Vel Máxima...: {0}", c1.velMax);
            Console.WriteLine("Ligado.......: {0}", c1.getLigado());
            Console.WriteLine("----------------------------------");
            Console.ReadLine();

            CarroCombate cc1 = new CarroCombate();
            Console.WriteLine("Nome.........: {0}", cc1.nome);
            Console.WriteLine("Cor..........: {0}", cc1.cor);
            Console.WriteLine("Rodas........: {0}", cc1.getRodas());
            Console.WriteLine("Vel Máxima...: {0}", cc1.velMax);
            Console.WriteLine("Ligado.......: {0}", cc1.getLigado());
            Console.WriteLine("Munição......: {0}", cc1.municao);
            Console.ReadLine();
        }
    }
}
