using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double a, b, c;
                Console.WriteLine("\n Digite o valor de uma expressão exponencial");
                Console.Write("Digite o Valor da base: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do expoente: ");
                b = int.Parse(Console.ReadLine());
                c = Math.Pow(a,b);

                Console.WriteLine("O valor da expressão:");
                Console.Write(c);

            }
        }
    }
}
