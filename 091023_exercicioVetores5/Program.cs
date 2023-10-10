namespace _091023_exercicioVetores5;

//5. Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

using System;

class Program
{
    static void Main()
    {
        // Declaração do vetor com 80 elementos
        int[] vetor = new int[80];

        // Leitura dos valores para o vetor
        Console.WriteLine("Digite os valores para o vetor:");
        for (int i = 0; i < 80; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Encontrando o menor elemento e sua posição
        int menorElemento = vetor[0];
        int posicaoMenor = 0;

        for (int i = 1; i < 80; i++)
        {
            if (vetor[i] < menorElemento)
            {
                menorElemento = vetor[i];
                posicaoMenor = i;
            }
        }

        // Exibindo o menor elemento e sua posição
        Console.WriteLine($"\nO menor elemento é {menorElemento}.");
        Console.WriteLine($"Sua posição no vetor é {posicaoMenor}.");
    }
}
