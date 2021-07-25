using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoDiagnostica
{
    class Conta_Corrente 
    {
        public string nome;
        public double salario;
        public int duracao;


        public double rendimento_cc_mensal()
        {
            return salario * 0.08;
        }
        public double rendimento_cc_duracao()
        {
            return duracao*salario * 0.08;
        }

    }
}
