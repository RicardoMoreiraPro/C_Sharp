using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Area
{
    public static float Quad(float bas, float alt)
    {
        if (bas == 0 || alt == 0)
        {
            throw new Exception("Base ou altura não pode ser igual a zero");
        }
        return bas * alt;
    }
}

namespace _47_Exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float area = 0;
            try
            {
                area = Area.Quad(10f, 0f);
                Console.WriteLine("Area do quadrado:{0}", area);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Ex: {0}", e.GetType());
            }
            finally
            {
                Console.WriteLine("Fim do processo!");
            }
            
            Console.ReadLine();

        }
    }
}
