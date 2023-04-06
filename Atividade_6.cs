using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double a, b, c;
                Console.WriteLine("\n Média Geométrica, digite quatro valores:");
                Console.Write("Digite o Valor do termo 1:");
                a = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do termo 2:");
                b = int.Parse(Console.ReadLine());

                c = Math.Sqrt(a * b);

                Console.WriteLine("O Resultado da Média Geométrica:");
                Console.Write(c);
            }
        }
    }
}
