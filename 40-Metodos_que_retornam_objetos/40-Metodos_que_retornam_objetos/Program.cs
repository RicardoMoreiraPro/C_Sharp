using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha) { 
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }
    public Ovo botar()
    {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}
class Ovo
{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha)
    {
        this.numOvo = numOvo;
        this.minhaGalinha=minhaGalinha;
        Console.WriteLine("Ovo criado:{0} - {1}", this.numOvo, this.minhaGalinha);
    }
}

namespace _40_Metodos_que_retornam_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Galinha g1 = new Galinha("Beneditasgildemar");
            Galinha g2 = new Galinha("Felizbertamiazilda");
            Galinha g3 = new Galinha("Marisgertrudeszela");

            g1.botar();
            g2.botar();
            g1.botar();
            g1.botar();
            g3.botar();
            g2.botar();
            g2.botar();
            g1.botar();
            g3.botar();
            Console.ReadLine();

        }
    }
}
