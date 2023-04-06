using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for ( ; ; )
            {
                double d, a, l, b;
                Console.WriteLine("\n Área de um Quadrado:");
                Console.Write("Digite o Valor da Diagonal:");
                d = int.Parse(Console.ReadLine());
                l = d/(1.41421356);
                a = l * l;
                    Console.WriteLine("O Resultado da Área é:");
                    Console.Write(a);
                    Console.Write(" m^2");
            }
        }
    }
}