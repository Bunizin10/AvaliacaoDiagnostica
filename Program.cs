using System;

namespace AvaliacaoDiagnostica
{
    class Program
    {
        static void Main(string[] args)
        {

            int tamanho = 10;
            int[] numeros = new int[tamanho];
            int restoDivisao = 0;

            bool encontrado = false;

            Console.WriteLine("Digite 10 Valores Inteiros :");
            for (int i = 0; i < tamanho; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um Valor Inteiro para Procurar :");
            int numeroProcurado = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] == numeroProcurado)
                {
                    encontrado = true;
                    restoDivisao = numeroProcurado % 2;
                    if (restoDivisao == 0)
                    {
                        Console.WriteLine("O número PAR {0} foi encontrado com sucesso!", numeros[i]);
                    }
                    else
                    {
                        Console.WriteLine("O número IMPAR {0} foi encontrado com sucesso!", numeros[i]);
                    }

                }

            }
            if (encontrado == false)
            {
                Console.WriteLine("O número {0} não foi encontrado!", numeroProcurado);
            }


        }
    }
}
