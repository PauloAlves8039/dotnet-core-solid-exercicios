using _02_Exercicio.Classes;
using _02_Exercicio.Interfaces;
using System;

namespace _02_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** EXERCÍCIO 01 *****");

            ILogger meuLogArquivo = new FileLogger();
            ILogger meuLogConsole = new ConsoleLogger();

            Pedido pedido = new Pedido(meuLogArquivo);
            pedido.AdicionarPedido();

            Console.WriteLine();
            Console.WriteLine("Arquivo adicionando com sucesso: " + meuLogConsole);

            Console.ReadLine();
        }
    }
}
