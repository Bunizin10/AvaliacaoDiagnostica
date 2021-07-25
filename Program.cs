using System;

namespace AvaliacaoDiagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta_Poupanca c1 = new Conta_Poupanca("Vinicius",2539,3,10,0.5) ;

            Console.WriteLine("Nome:{0}", c1.nome);
            Console.WriteLine("Salario:{0}", c1.salario);
            Console.WriteLine("Duração:{0}", c1.duracao);
            Console.WriteLine("Desconto:{0}", c1.desconto);
            Console.WriteLine("Taxa:{0}", c1.taxa);
            Console.WriteLine("Rendimento CC Mensal:{0}", c1.rendimento_cc_mensal());
            Console.WriteLine("Rendimento CC Duracao:{0}", c1.rendimento_cc_duracao());
            Console.WriteLine("Rendimento CP Mensal:{0}", c1.rendimento_cp_mensal());
            Console.WriteLine("Rendimento CP Duracao:{0}", c1.rendimento_cp_duracao());
        }
    }
}
