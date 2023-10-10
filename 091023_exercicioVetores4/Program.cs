namespace _091023_exercicioVetores4;
//4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice,
//colocando o resultado em um terceiro vetor.Mostre o vetor resultante.
using System;

class Program
{
    static void Main()
    {
        // Declaração dos vetores com 10 posições
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int[] vetorResultado = new int[10];

        // Leitura dos valores para o primeiro vetor
        Console.WriteLine("Digite os valores para o primeiro vetor:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        // Leitura dos valores para o segundo vetor
        Console.WriteLine("\nDigite os valores para o segundo vetor:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        // Multiplicação dos elementos e armazenamento no vetor resultado
        for (int i = 0; i < 10; i++)
        {
            vetorResultado[i] = vetor1[i] * vetor2[i];
        }

        // Exibição do vetor resultante
        Console.WriteLine("\nVetor resultante da multiplicação:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Posição {i}: {vetorResultado[i]}");
        }
    }
}
