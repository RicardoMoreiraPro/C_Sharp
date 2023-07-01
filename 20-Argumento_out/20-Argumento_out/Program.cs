using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Argumento_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divid,divis,quoc,rest;
            divid = 13;
            divis = 5;
            quoc = divite(divid, divis,out rest);
            Console.WriteLine("{0}/{1} = quociente = {2} e resto = {3}",divid, divis,quoc,rest);
            Console.ReadLine();
        }

        static int divite(int dividendo,  int divisor,out int resto)
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }

        

    }
}
