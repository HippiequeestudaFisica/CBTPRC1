using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for ( ; ; )
            {
                double a, c;
                Console.WriteLine("\n Converter Celsiuns para Fahrenheints:");
                Console.Write("Digite o Valor de Celsiuns: ");
                a = int.Parse(Console.ReadLine());
                c = (a * 9)/(5)+32;


                Console.WriteLine("Em Fahrenheints:");
                Console.Write(c);
                Console.Write(" ºF");
            }
        }
    }
}