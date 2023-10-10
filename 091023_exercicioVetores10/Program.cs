namespace _091023_exercicioVetores10;
//10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições.
//Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.
using System;

class Program
{
    static void Main()
    {
        // Declaração dos vetores com 20 posições
        int[] vetor = new int[20];
        int[] vetorResultado = new int[20];

        // Leitura dos valores para o vetor
        Console.WriteLine("Digite 20 números inteiros:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Substituindo os valores nulos por 2 no vetor resultado
        for (int i = 0; i < 20; i++)
        {
            if (vetor[i] == 0)
            {
                vetorResultado[i] = 2;
            }
            else
            {
                vetorResultado[i] = vetor[i];
            }
        }

        // Exibição do vetor lido
        Console.WriteLine("\nVetor lido:");
        foreach (int numero in vetor)
        {
            Console.Write($"{numero} ");
        }

        // Exibição do vetor resultado
        Console.WriteLine("\nVetor resultado:");
        foreach (int numero in vetorResultado)
        {
            Console.Write($"{numero} ");
        }
    }
}
