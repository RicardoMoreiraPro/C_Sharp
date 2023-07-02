using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Veiculo
{
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public Veiculo(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public bool getLigado()
    {
        return ligado;
    }
    public int getVelMax()
    {
        return velMax;
    }
}
class Carro : Veiculo
{
    public string nome;
    public Carro(string nome, int vm):base(vm)
    {
        this.nome = nome;
        ligado=true;

    }
}

namespace _30_Membros_protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Bonitão", 120);
            Console.WriteLine("Nome do carro: {0}",carro.nome);
            Console.WriteLine("Vel Maxima: {0}", carro.getVelMax());
            Console.WriteLine("Ligado: {0}", carro.getLigado());
            Console.ReadLine();
        }
    }
}
