﻿using _03_Exercicio.Interfaces;

namespace _03_Exercicio.Classes
{
    public class CalculaImpostoArgentina : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 40 / 100;
        }
    }
}
