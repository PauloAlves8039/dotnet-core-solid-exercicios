using _05_Exercicio.Classes;
using System;

namespace _05_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** EXERCÍCIO 05 *****");

            var p1 = new Pizzaria(new PizzaFactory());
            p1.CriarPizza("mussarela");
            p1.CriarPizza("calabresa");

            Console.ReadLine();
        }
    }
}
