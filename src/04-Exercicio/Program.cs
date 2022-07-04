using _04_Exercicio.Classes;
using System;

namespace _04_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** EXERCÍCIO 04 *****");

            Produto celularSamSung = new Celular(new PromocaoDiaMaes());
            celularSamSung.Nome = "Celular SamSumg Galaxy M10";
            celularSamSung.Preco = 1000;
            var precoCelular = celularSamSung.PrecoVenda();
            Console.WriteLine($"{celularSamSung.Nome} (20% Off) : {precoCelular}");

            Produto perfumeChanel = new Perfume(new PromocaoDiaNamorados());
            perfumeChanel.Nome = "Perfume Chanel Blue";
            perfumeChanel.Preco = 500;
            var precoChanel = perfumeChanel.PrecoVenda();
            Console.WriteLine($"{perfumeChanel.Nome} (10% Off) : {precoChanel}");

            Console.ReadLine();
        }
    }
}
