using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for( ; ; ) {
                double b, h, a;
                Console.WriteLine("\n Área de um Retângulo:");
                Console.Write("Digite o Valor da Base:");
                b = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor da Altura:");
                h = int.Parse(Console.ReadLine());
                a = b * h;
                Console.WriteLine("O Resultado da Área é:");
                Console.Write(a);
                Console.Write(" m^2");
            }
        }
    }
}
