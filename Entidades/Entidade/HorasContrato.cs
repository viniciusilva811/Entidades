using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entidade
{
    class HorasContrato
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public HorasContrato() 
        {
        }

        public HorasContrato(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal() 
        {
            return Horas * ValorPorHora;
        }
    }
}
