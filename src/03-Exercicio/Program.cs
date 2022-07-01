using _03_Exercicio.Classes;
using _03_Exercicio.Interfaces;
using System;

namespace _03_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** EXERCÍCIO 03 *****");

            ICalcularImpostoPais calc = new CalculaImpostoBrazil();
            calc.TotalRenda = 1000;
            calc.TotalDeducao = 100;

            var calcImp = new CalcularImposto();
            var valorTotalImposto = calcImp.Calcular(calc);
            Console.WriteLine($"Brasil {valorTotalImposto}");

            Console.ReadLine();
        }
    }
}
