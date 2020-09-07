using Curso.Entidade;
using Curso.Entidade.Enumerados;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();

            Console.WriteLine("Entre com o nome do Funcionario: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível - Junior, Pleno, Senior: ");
            /*converter de enum para string que sera digitado*/
            NivelFuncionario nivel = Enum.Parse<NivelFuncionario>(Console.ReadLine());

            Console.WriteLine("Entre com o salario base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamentos departamentos = new Departamentos(nomeDepartamento);

            Funcionario func = new Funcionario(nome, nivel, salarioBase, departamentos);

            Console.WriteLine("Quantos contratos serao cadastrados ? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) 
            {
                Console.WriteLine($"Entre #{i} data do contrato: ");
                Console.Write("Data = (DIA/MES/ANO): ");
                
                DateTime data = DateTime.Parse(Console.ReadLine());

            }
            
        }
    }
}
