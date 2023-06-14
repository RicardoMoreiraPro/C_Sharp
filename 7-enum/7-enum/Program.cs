using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_enum
{
    internal class Program
    {
        enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado };
        static void Main(string[] args)
        {
            //DiasSemana ds = DiasSemana.Domingo; ou
            DiasSemana ds = (DiasSemana)5; //ou
            int ds2 = (int)DiasSemana.Sexta;
            Console.WriteLine(ds);
            Console.WriteLine(ds2);
            Console.ReadLine();
        }
    }
}
