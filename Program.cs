using System;

namespace AvaliacaoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o nome do funcionario:");
            string nome1= Console.ReadLine();
            Console.WriteLine("Digite 1 caso seja funcionario da empresa ou digite 2 caso seja funcionario terceirizado:");
            int tipo1 = int.Parse(Console.ReadLine());
 
       
            Console.WriteLine("Digite o nome do funcionario:");
            string nome2= Console.ReadLine();
            Console.WriteLine("Digite 1 caso seja funcionario da empresa ou digite 2 caso seja funcionario terceirizado:");
            int tipo2 = int.Parse(Console.ReadLine());

            if (tipo1 == 1)
            {
                Funcionario funcionario1 = new Funcionario(nome1, 8, 32.50);
            }else if (tipo1 == 2)
            {
                Funcionario funcionario2 = new FuncionarioTerceirizado(nome1, 8, 32.50, "ITAÚ", 0.07);
            }

            if (tipo2 == 1)
            {
                Funcionario funcionario1 = new Funcionario(nome2, 8, 32.50);
            }
            else if (tipo2 == 2)
            {
                Funcionario funcionario2 = new FuncionarioTerceirizado(nome2, 8, 32.50, "ITAÚ", 0.07);
            }


        }
    }
}
