namespace _061023_exercicioRepeticao_pt2_9;
//9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram
//o zoológico num determinado dia, imprimindo:
//Quantas pessoas tem entre 1 e 3 filhos.
//Quantas pessoas tem entre 4 e 7 filhos.
//Quantas pessoas tem mais de 8 filhos.
//Quantas pessoas não tem filhos.

    using System;

class Program
{
    static void Main()
    {
        int pessoasCom1a3Filhos = 0;
        int pessoasCom4a7Filhos = 0;
        int pessoasComMaisDe8Filhos = 0;
        int pessoasSemFilhos = 0;

        for (int i = 1; i <= 30; i++)
        {
            Console.Write($"Quantidade de filhos da pessoa {i}: ");
            int quantidadeDeFilhos = int.Parse(Console.ReadLine());

            if (quantidadeDeFilhos >= 1 && quantidadeDeFilhos <= 3)
            {
                pessoasCom1a3Filhos++;
            }
            else if (quantidadeDeFilhos >= 4 && quantidadeDeFilhos <= 7)
            {
                pessoasCom4a7Filhos++;
            }
            else if (quantidadeDeFilhos > 8)
            {
                pessoasComMaisDe8Filhos++;
            }
            else if (quantidadeDeFilhos == 0)
            {
                pessoasSemFilhos++;
            }
        }

        Console.WriteLine($"Pessoas com entre 1 e 3 filhos: {pessoasCom1a3Filhos}");
        Console.WriteLine($"Pessoas com entre 4 e 7 filhos: {pessoasCom4a7Filhos}");
        Console.WriteLine($"Pessoas com mais de 8 filhos: {pessoasComMaisDe8Filhos}");
        Console.WriteLine($"Pessoas sem filhos: {pessoasSemFilhos}");
    }
}
