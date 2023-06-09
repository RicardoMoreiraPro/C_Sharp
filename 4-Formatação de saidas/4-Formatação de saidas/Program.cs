using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Formatação_de_saidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            n1 = 10; n2 = 20; n3 = 30;
            Console.WriteLine("\nn1 = \t{0} \nn2 = \t{1} \nn3 = \t{2}", n1, n2, n3);
            Console.ReadLine();

            double ValorCompra = 5.50;
            double ValorVenda;
            double lucro = 0.1;
            string produto = "Pastel";
            ValorVenda = ValorCompra + (ValorCompra * lucro);

            Console.WriteLine("Produto..........: {0,15}", produto);
            Console.WriteLine("Valor Compra.....: {0,15:c}", ValorCompra);
            Console.WriteLine("Lucro............: {0,15:p}", lucro);
            Console.WriteLine("Valor venda......: {0,15:c}", ValorVenda);
            Console.ReadLine() ;
        }
    }
}
