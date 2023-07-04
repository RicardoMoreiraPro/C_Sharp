using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Veiculo
{
    
    public int valor;
    private int ano;
    protected string cor;
    private int velMax;
    public Veiculo(int valor, int ano, string cor, int velMax) 
    {
        this.valor = valor;
        this.ano = ano;
        this.cor = cor;
        this.velMax = velMax;
    }
    public int getAno()
    {
        return ano;
    }
    public int getVelMax()
    {
        return velMax;
    }
}
class Carro : Veiculo
{
    private string categoria;
    public int portas;
    public bool airbag;
    public Carro(string categoria, int portas, bool airbag, int valor, int ano, string cor, int velMax) : base(valor, ano, cor, velMax)
    {
        this.categoria = categoria;
        this.portas = portas;
        this.airbag = airbag;
    }
    public void info()
    {
        Console.WriteLine("Veiculo.............: Carro");
        Console.WriteLine("Categoria...........: {0}", categoria);
        Console.WriteLine("Numero de portas....: {0}", portas);
        Console.WriteLine("Tem air bag.........: {0}", airbag);
        Console.WriteLine("Ano de fabricação...: {0}", getAno());
        Console.WriteLine("Cor do carro........: {0}", cor);
        Console.WriteLine("Velocidade Máxima...: {0}", getVelMax());
        Console.WriteLine("Valor de venda......: {0}", valor);
    }
}
class Moto : Veiculo
{
    public string categoria;
    public int rodas;
    private bool alarme;
    public Moto(string categoria, bool alarme, int valor, int ano, string cor, int velMax) : base(valor, ano, cor, velMax)
    {
        this.categoria = categoria;
        rodas = 2;
        this.alarme = alarme;
    }
    public void info()
    {
        Console.WriteLine("Veiculo............: Moto");
        Console.WriteLine("Categoria..........: {0}", categoria);
        Console.WriteLine("Numero de rodas....: {0}", rodas);
        Console.WriteLine("Tem alarme.........: {0}", alarme);
        Console.WriteLine("Ano de fabricação..: {0}", getAno());
        Console.WriteLine("Cor da moto........: {0}", cor);
        Console.WriteLine("Velocidade Máxima..: {0}", getVelMax());
        Console.WriteLine("Valor de venda.....: {0}", valor);
    }
}

namespace Pratica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____ Mundo dos Automóveis _____");
            Console.WriteLine("Olá, como podemos te chamar?");
            string nome = Console.ReadLine();
            Console.WriteLine("{0}, vamos começar o cadastro do seu veiculo!", nome);
            tipo:
            Console.WriteLine("Primeiramente nos diga qual o seu veiculo, carro ou moto?");
            string tipo = Console.ReadLine();
            switch (tipo)
            {
                case ("carro"):
                case ("Carro"):
                case ("moto"):
                case ("Moto"):
                    Console.WriteLine("Ok {0}, já que voce tem um(a) {1}, vamos as perguntas", nome, tipo);
                    Console.WriteLine("Qual o valor do(a) seu(sua) {0}?", tipo);
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine("E qual o ano de fabrição?");
                    int ano = int.Parse(Console.ReadLine());
                    Console.WriteLine("E a cor dele?");
                    string cor = Console.ReadLine();
                inicio:
                    Console.WriteLine("Já testou a velocidade do seu(sua) possante?[sim/não]");
                    string velocidade = Console.ReadLine();
                    switch (velocidade)
                    {
                        case ("sim"):
                        case ("Sim"):
                            Console.WriteLine("Você é um piloto de verdade, nos diga qual a velocidade máxima do seu(sua) {0}", tipo);
                            int velMax = int.Parse(Console.ReadLine());
                            if (tipo == "carro" || tipo == "Carro")
                            {
                                Console.WriteLine("Agora nos diga a categoria do seu {0}", tipo);
                                string categoria = Console.ReadLine();
                                Console.WriteLine("E quantas portas ele tem?");
                                int portas = int.Parse(Console.ReadLine());
                                Console.WriteLine("E para finalizar, ele tem air bag? [1] Sim  [2] Não");
                                int air_bag = int.Parse(Console.ReadLine());
                                bool airbag;
                                if (air_bag == 1)
                                {
                                    airbag = true;
                                }
                                else
                                {
                                    airbag = false;
                                }
                                Carro carro = new Carro(categoria, portas, airbag, valor, ano, cor, velMax);
                                Console.WriteLine("________________________________________");
                                Console.WriteLine("Agora vamos aos dados gravados:");
                                carro.info();
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Agora nos diga a categoria da sua {0}", tipo);
                                string categoria = Console.ReadLine();
                                Console.WriteLine("E para finalizar, ele tem alarme? [1] Sim  [2] Não");
                                int alar = int.Parse(Console.ReadLine());
                                bool alarme;
                                if (alar == 1)
                                {
                                    alarme = true;
                                }
                                else
                                {
                                    alarme = false;
                                }
                                Moto moto = new Moto(categoria,alarme, valor, ano, cor, velMax);
                                Console.WriteLine("________________________________________");
                                Console.WriteLine("Agora vamos aos dados gravados:");
                                moto.info();
                                Console.ReadLine();
                            }  
                        break;
                        case ("nao"):
                        case ("Nao"):
                        case ("não"):
                        case ("Não"):
                            Console.WriteLine("Que pena, você não é um piloto de verdade!");
                            Console.WriteLine("Teste a velocidade máxima e quando souber volte para continuarmos a gravação do seu(sua) {0}", tipo);
                            Console.WriteLine("Nós so trabalhamos com verdadeiros pilotos, mas não desanime, um dia você consegue se tornar um!");
                            Console.WriteLine("Até lá!!!");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Resposta inválida, voltemos a pergunta");
                            goto inicio;
                    }
                    break;
                default:
                    Console.WriteLine("Resposta inválida, voltemos a pergunta");
                    goto tipo;
            }
        }
    }
}
