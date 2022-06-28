using _01_Exercicio.Classes;
using System;

namespace _01_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** EXERCÍCIO 01 *****");

            var resultado = Cliente.ObterListaDeClientes();

            Console.WriteLine();

            try
            {
                ExportarDados.ExportarArquivo(resultado);
                Console.WriteLine("Gerando arquivo com lista de clientes!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Erro ao gerar arquivo com lista de Clientes: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
