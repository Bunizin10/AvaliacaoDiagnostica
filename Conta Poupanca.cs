using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoDiagnostica
{
    class Conta_Poupanca : Conta_Corrente
    {
        public double desconto;
        public double taxa;

        public Conta_Poupanca(string nome, double salario, int duracao, double desconto, double taxa)
        {
            this.nome = nome;
            this.salario = salario;
            this.duracao = duracao;
            this.desconto = desconto;
            this.taxa = taxa;
            rendimento_cc_mensal();
            rendimento_cc_duracao();
            rendimento_cp_mensal();
            rendimento_cp_duracao();
        }

        public double rendimento_cp_mensal()
        {
            return (salario * 0.09) - desconto*taxa;
        }
        public double rendimento_cp_duracao()
        {
            return (duracao * salario * 0.09) - desconto*taxa;
        }
    }
}
