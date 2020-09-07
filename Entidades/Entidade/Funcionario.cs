using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using Curso.Entidade.Enumerados;
using Microsoft.VisualBasic;

namespace Curso.Entidade
{
    class Funcionario
    {
        public string Nome { get; set; }
        public NivelFuncionario Nivel { get; set; }
        public double SalarioBase { get; set; }

        /* é para fazer uma composição de objetos no final*/
        public Departamentos Departamentos { get; set; }

        /* como podem ser usados varios contatos, 
         é preciso de uma lista para usar todos no final*/
        public List<HorasContrato> Contratos { get; set; }
            = new  List<HorasContrato>();

        public Funcionario() 
        {
        }

        public Funcionario(string nome, NivelFuncionario nivel, double salarioBase, Departamentos departamentos)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamentos = departamentos;
        }

        public void AdicionarContrato(HorasContrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(HorasContrato contrato) 
        {
            Contratos.Remove(contrato);
        }

        public double Ganhos(int ano, int mes) 
        {
            double soma = SalarioBase;
            foreach(HorasContrato contrato in Contratos) 
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        } 
    }
}
