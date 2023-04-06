using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double a, b, c;
                Console.WriteLine("\n Encontrar a Área de um Círculo:");
                Console.Write("Digite o Valor do diâmetro: ");
                a = int.Parse(Console.ReadLine());
                b = ((a*a)/(2*2))*(3.14159265359);


                Console.WriteLine("A Área do Círculo:");
                Console.Write(b);
                Console.Write(" m^2");
            }
        }
    }
}