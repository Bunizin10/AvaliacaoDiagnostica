using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoFinal
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int cargaHoraria;

        public double valorHora;
        public double salario;

        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            this.Nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.valorHora = valorHora;
            calculaSalario();
        }
        public Funcionario()
        {
            
        }

        public virtual void calculaSalario()
        {
            salario = valorHora * cargaHoraria;
            Console.WriteLine("Nome:{0}", Nome);
            Console.WriteLine("Salario:{0}", salario);

        }

    }
}
