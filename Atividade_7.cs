using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double a, b, c;
                Console.WriteLine("\n Converter milhas para quilômetros:");
                Console.Write("Digite o Valor da milha: ");
                a = int.Parse(Console.ReadLine());
                c = a * 1852;
                b = c / 1000;
                Console.WriteLine("Em quilômetros:");
                Console.Write(b);
                Console.Write(" km");
            }
        }
    }
}
