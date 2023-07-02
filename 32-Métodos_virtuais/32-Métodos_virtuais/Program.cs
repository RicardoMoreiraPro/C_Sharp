using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }
    virtual public void info()
    {
        Console.WriteLine("Base");
    }
}
class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivda1");
    }
    override public void info()
    {
        Console.WriteLine("Derivada 1");
    }

}
class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivda2");
    }
    override public void info()
    {
        Console.WriteLine("Derivada 2");
    }
}

namespace _31_Ordem_de_execucao_construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base Ref;
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();
            
            Ref=derivada2;
            Ref.info();
            
            Console.ReadLine();
        }
    }
}