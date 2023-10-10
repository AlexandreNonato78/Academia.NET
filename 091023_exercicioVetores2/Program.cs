namespace _091023_exercicioVetores2;
using System;

//2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então
//realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.


class Program
{
    static void Main()
    {
        // Declaração dos vetores com 20 elementos
        int[] vetor1 = new int[20];
        int[] vetor2 = new int[20];
        int[] vetorSoma = new int[20];

        // Leitura dos valores para o primeiro vetor
        Console.WriteLine("Digite os valores para o primeiro vetor:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        // Leitura dos valores para o segundo vetor
        Console.WriteLine("\nDigite os valores para o segundo vetor:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        // Realização da soma e armazenamento no terceiro vetor
        for (int i = 0; i < 20; i++)
        {
            vetorSoma[i] = vetor1[i] + vetor2[i];
        }

        // Exibição do vetor resultante
        Console.WriteLine("\nResultado da soma dos vetores:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Posição {i}: {vetorSoma[i]}");
        }
    }
}
