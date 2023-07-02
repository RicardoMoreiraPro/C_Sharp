using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Calculos
{
    public int v1;
    public int v2;

    public Calculos(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
        Console.WriteLine("{0} e {1}", v1, v2);
    }

    public int Somar()
    {
        Console.WriteLine("{0} e {1}", v1, v2);
        return v1 + v2;
    }
}

namespace _26_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculos c = new Calculos(10, 2);
            Calculos d = new Calculos(5, 1);
            int b = c.Somar();
            int e = d.Somar();
            Console.WriteLine(b);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
