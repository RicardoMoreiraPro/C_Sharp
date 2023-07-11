using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            res=n1=n2 = 0;

            n1 = 10;
            n2 = 0;
            try
            {
                res = n1 / n2;
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: {0}",e.Message);
                Console.WriteLine("Ex: {0}",e.GetType());
            }
            Console.WriteLine("{0}/{1} = {2}",n1,n2,res);
            Console.ReadLine();
        }
    }
}
