using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}
public interface Combate
{
    void disparar();
}

class Carro:Veiculo,Combate
{
    public bool ligado;
    private int municao;
    public void setMunicao(int qtde)
    {
        this.municao = qtde;
    }
    public Carro()
    {
        setMunicao(100);
    }
    public void ligar()
    {
        this.ligado = true;
    }
    public void desligar()
    {
        this.ligado = false;
    }
    public void info()
    {

    }
    public void disparar()
    {

    }
}

namespace _37_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            Console.ReadLine();
        }
    }
}
