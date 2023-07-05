using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Veiculo
{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }
    public int getVelAtual()
    {
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}
class Carro : Veiculo
{
    public Carro()
    {
        velMaxima = 120;
    }
    override public void aceleracao(int mult)
    {
        velAtual +=10* mult;
    }
    
}

namespace _33_Classes_e_metodos_abstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.aceleracao(1);
            Console.WriteLine(carro1.getVelAtual());
            
            Console.ReadLine();
        }
    }
}
