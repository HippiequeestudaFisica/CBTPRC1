using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double h, a, b;
                Console.WriteLine("\n Área de um Triângulo Retângulo:");
                Console.Write("Digite o Valor da Altura:");
                h = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor da Base:");
                b = int.Parse(Console.ReadLine());
                a = (b * h)/2;
                Console.WriteLine("O Resultado da Área é:");
                Console.Write(a);
                Console.Write(" m^2");
            }
        }
    }
}