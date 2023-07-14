using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Colecao_list_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string>carros=new List<string>();
            List<string> carros2 = new List<string>();
            string[] carros3 = new string[7];

            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");

            carros2.AddRange(carros); //Para adicionar todos os elementos de carros em carros2
            carros2.Clear();

            foreach(string c in carros)
            {
                Console.WriteLine("Carros: {0}",c);
            }

            if (carros.Contains("Golf"))
            {
                Console.WriteLine("Esta na lista");
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
            carros.CopyTo(carros3,2);
            foreach(string b in carros3)
            {
                Console.WriteLine("Carros : {0}",b);
            }
            string d = "HRV";
            int pos;
            pos = carros.IndexOf(d);
            Console.WriteLine("Carro {0} está na posição {1}",d,pos);
            Console.ReadLine();
        }
    }
}
