using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_GitHub_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            Console.WriteLine("Programa para calcular a soma de dois numeros inteiros.");
            Console.Write("Primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("A soma de {0} com {1} é {2}", n1, n2, soma);
            Console.ReadKey();
        }
    }
}
