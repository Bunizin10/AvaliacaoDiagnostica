using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoFinal
{
    class FuncionarioTerceirizado : Funcionario
    {

        public string empresaOrigem;
        public double taxaServiço;

        public FuncionarioTerceirizado(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServiço)
        {
            this.Nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.valorHora = valorHora;
            this.empresaOrigem = empresaOrigem;
            this.taxaServiço = taxaServiço;
            calculaSalario();
        }
        public FuncionarioTerceirizado()
        {
           
        }
        public override void calculaSalario()
        {
            salario = (valorHora * cargaHoraria) + (valorHora * cargaHoraria)*taxaServiço;
            Console.WriteLine("Nome:{0}", Nome);
            Console.WriteLine("Empresa de origem:{0}", empresaOrigem);
            Console.WriteLine("Salario:{0}", salario);

        }


    }
}
