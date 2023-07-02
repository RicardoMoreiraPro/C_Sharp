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
}
class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivda1");
    }
}
class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivda2");
    }
}

namespace _31_Ordem_de_execucao_construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derivada2 deivada2 = new Derivada2();
            Console.ReadLine();
        }
    }
}
