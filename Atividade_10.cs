using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double a, b, c;
                Console.WriteLine("\n Dolar converter para Reais");
                Console.Write("Digite o Valor do Dolar: ");
                a = int.Parse(Console.ReadLine());
                b = a*(5.034);


                Console.WriteLine("O valor em Reais: ");
                Console.Write(b);
                Console.Write(" R$");
            }
        }
    }
}
