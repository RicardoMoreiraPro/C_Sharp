using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17__Métodos__para_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

            Random random = new Random();
            for (int i = 0;i<vetor1.Length;i++)
            {
                vetor1[i] = random.Next(50);
            }
            Console.WriteLine("Elementos do vetor1");
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

            //public static int BinarySearch(array, valor);
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            int pos = Array.BinarySearch(vetor1,procurado);
            Console.WriteLine("Valor {0} está na posição {1}",procurado, pos);
            Console.WriteLine("______________________________");
            Console.ReadLine();
            
            //public static void copy(Ar_origem, Ar_destino, qtde_elementos);
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach(int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //public void CopyTo(Ar_destino, a_partir_desta_pos);
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);
            foreach(int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadLine() ;

            //public long GetLongLength(dimensão);
            Console.WriteLine("GetLongLength");
            long qtdeElementosVetor = vetor1.GetLongLength(0);
            Console.WriteLine("Quantidade de elementos {0}",qtdeElementosVetor);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //pulic int GetLowerBound(dimensão);
            Console.WriteLine("GetLowerBound");
            int MenorIndiceVetor = vetor1.GetLowerBound(0);
            int MenorIndiceMatriz_D1 = matriz.GetLowerBound(0);
            Console.WriteLine("Menor indice do vetor1 {0}", MenorIndiceVetor);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //public int GetUpperBound(dimensão);
            Console.WriteLine("GetUpperBound");
            int MaiorIndiceVetor = vetor1.GetUpperBound(0);
            int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
            Console.WriteLine("Maior indice do vetor1 {0}", MaiorIndiceVetor);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //public object GetValue(long indice);
            Console.WriteLine("GetValue");
            int valor0 = Convert.ToInt32(vetor1.GetValue(3));
            int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
            Console.WriteLine("Valor da posição 3 no vetor1; {0}", valor0);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //public static int IndexOf(array,valor);
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1, 3);
            Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //public static int LastIndexOf(array,valor);
            Console.WriteLine("LastIndexOf");
            int indice2 = Array.LastIndexOf(vetor1, 3);
            Console.WriteLine("Indice do ultimo valor 33: {0}", indice2);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //public static void Reverse(array);
            Array.Reverse(vetor1);
            foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //public void SetValue(object valor, posição);
            vetor2.SetValue(99, 0);
            for(int i = 0; i <vetor2.Length; i++)
            {
                vetor2.SetValue(0, i);
            }
            foreach(int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            //public static void Sort(array); ordenar em ordem crescente, se quiser decrescente usar o inverse tambem
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Console.WriteLine("vetor1");
            foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nvetor2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nvetor3");
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();


        }
    }
}
