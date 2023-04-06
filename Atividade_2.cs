using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for ( ; ; )
            {
                double b, h, a;
                Console.WriteLine("\n Área de um Quadrado:");
                Console.Write("Digite o Valor da Base:");
                b = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor da Altura:");
                h = int.Parse(Console.ReadLine());
                if (b != h)
                {
                    Console.WriteLine("Desculpe, mas a altura é diferente da base, logo não é um quadrado, tente de novo!");

                }
                else
                {
                    a = b * h;
                    Console.WriteLine("O Resultado da Área é:");
                    Console.Write(a);
                    Console.Write(" m^2");

                }
            }
        }
    }
}