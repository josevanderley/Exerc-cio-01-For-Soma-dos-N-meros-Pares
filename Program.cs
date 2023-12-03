using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01_For__Soma_dos_Números_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro N: ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 2; i <= N; i += 2)
            {
                soma += i;
            }

            Console.WriteLine($"A soma dos números pares de 1 a {N} é: {soma}");

            Console.ReadKey();
        }
    }
}
    
