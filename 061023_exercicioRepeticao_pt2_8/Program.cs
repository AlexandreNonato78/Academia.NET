namespace _061023_exercicioRepeticao_pt2_8;
using System;

//e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar.
//Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            int numero = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Digite um número inteiro: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro.");
                }
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é um número par.");
            }
            else
            {
                Console.WriteLine($"{numero} é um número ímpar.");
            }

            Console.Write("Deseja repetir o programa (s/n)? ");
            char resposta = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (resposta != 's' && resposta != 'S')
            {
                continuar = false;
            }
        }
    }
}
