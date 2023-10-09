namespace _061023_exercicioRepeticao_pt2_6;
//6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
// ou seja, repita a leitura até que ela esteja correta(maior do que zero).
// Ao final, mostre a idade digitada.

    using System;

class Program
{
    static void Main()
    {
        int idade = 0;
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.Write("Informe a idade (deve ser maior que zero): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out idade) && idade > 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Idade incorreta! A idade deve ser um número inteiro maior que zero.");
            }
        }

        Console.WriteLine($"Idade informada: {idade}");
    }
}
