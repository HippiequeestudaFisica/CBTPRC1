using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double a, b, c, d, e, f, g;
                Console.WriteLine("\n O Valores do Produto");
                Console.Write("Digite o Valor do Primeiro Produto: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do Segundo Produto: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do Terceiro Produto: ");
                c = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do Quarto Produto: ");
                d = int.Parse(Console.ReadLine());
                Console.Write("Digite o Valor do Quinto Produto: ");
                e = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Quanto foi pago:");
                f = int.Parse(Console.ReadLine());
                if (f > (a + b + c + d + e)) {
                    g = -1*((a + b + c + d + e) - f);
                    Console.WriteLine("Você deve dar de troco:");
                    Console.Write(g);
                    Console.Write(" R$");
                }
                if (f < (a + b + c + d + e))
                {
                    g = (a + b + c + d + e) - f;
                    Console.WriteLine("A pessoa deve:");
                    Console.Write(g);
                    Console.Write(" R$");
                }
                else (f = (a + b + c + d + e))
                {
                    g = (a + b + c + d + e) - f;
                    Console.WriteLine("A pessoa pagou no valor exato.");
                    Console.Write(g);
                    Console.Write(" R$ de troco");
                }
            }
        }
    }
}