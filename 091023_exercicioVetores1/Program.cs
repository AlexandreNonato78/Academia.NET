namespace _091023_exercicioVetores1;
//1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e
//então mostre na tela a quantidade de números pares e ímpares.
using System;

class Program
{
    static void Main()
    {
        // Declaração do vetor com 10 elementos
        int[] vetor = new int[10];

        // Variáveis para contar os números pares e ímpares
        int pares = 0;
        int impares = 0;

        // Leitura dos valores para o vetor
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Verificação dos números pares e ímpares
        foreach (int numero in vetor)
        {
            if (numero % 2 == 0)
            {
                // Número par
                pares++;
            }
            else
            {
                // Número ímpar
                impares++;
            }
        }

        // Exibição dos resultados
        Console.WriteLine($"Quantidade de números pares: {pares}");
        Console.WriteLine($"Quantidade de números ímpares: {impares}");
    }
}
