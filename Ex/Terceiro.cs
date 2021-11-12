using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Terceiro : Funcionario
    {
        public string EmpresaOrigem { get; set; }
        public double TaxaServico { get; set; }
            
        public Terceiro()
        {
        }
        public Terceiro(string nome, int cargaHoraria, double valorHora,
            string empresaOrigem, double taxaServico) : base(nome, cargaHoraria, valorHora)
        {
            EmpresaOrigem = empresaOrigem;
            TaxaServico = taxaServico;
        }

        public override double CalcularSalario()
        {
            return CargaHoraria * ValorHora * (1 + TaxaServico);
        }

        public override void ImprimeDados()
        {
            double salario = this.CalcularSalario();
            Console.WriteLine($"O funcionário {Nome} da empresa {EmpresaOrigem} tem um salário de R${salario:0.00}");
        }
    }
}
