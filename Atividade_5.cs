using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double a,b,c,d,e;
                Console.WriteLine("\n Média Aritmética, digite quatro valores:");
                Console.Write("Digite o Valor do termo 1:");
                a = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do termo 2:");
                b = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do termo 3:");
                c = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do termo 4:");
                d = int.Parse(Console.ReadLine());
                e = (a+b+c+d)/4;
                Console.WriteLine("O Resultado da Média Aritmética:");
                Console.Write(e);
            }
        }
    }
}
