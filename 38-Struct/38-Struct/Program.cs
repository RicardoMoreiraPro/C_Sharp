using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor) { 
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info()
    {
        Console.WriteLine("Marca.....:{0}", this.marca);
        Console.WriteLine("Modelo....:{0}", this.modelo);
        Console.WriteLine("Cor.......:{0}", this.cor);
    }
}

namespace _38_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1;
            c1.marca = "Volkswagem";
            c1.modelo = "Golf";
            c1.cor = "Azul";
            Carro c2 = new Carro("Honda","HRV", "Prata");
            Console.WriteLine("Marca.....:{0}", c1.marca);
            Console.WriteLine("Modelo....:{0}", c1.modelo);
            Console.WriteLine("Cor.......:{0}", c1.cor);

            Console.WriteLine("Marca.....:{0}", c2.marca);
            Console.WriteLine("Modelo....:{0}", c2.modelo);
            Console.WriteLine("Cor.......:{0}", c2.cor);

            Carro c3;
            c3.marca = "BMW";
            c3.modelo = "320i";
            c3.cor = "Branco";
            c3.info();
            Console.ReadLine();
            
        }
    }
}
