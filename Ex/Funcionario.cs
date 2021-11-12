using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public double ValorHora { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
        }
        public virtual double CalcularSalario()
        {
            return CargaHoraria * ValorHora;
        }
        public virtual void ImprimeDados()
        {
            double salario = this.CalcularSalario();
            Console.WriteLine($"O funcionário {Nome} tem um salário de R${salario:0.00}");
        }

    }
}
