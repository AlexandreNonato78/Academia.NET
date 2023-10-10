namespace _091023_exercicioVetores9;
//9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida
//ordene em ordem crescente //os valores desse vetor, utilizando um vetor auxiliar.

using System;

class Program
{
    static void Main()
    {
        // Declaração de um vetor com 10 elementos
        int[] vetor = new int[10];
        int[] vetorOrdenado = new int[10];

        // Leitura dos valores para o vetor
        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Copiando os valores para o vetor auxiliar
        Array.Copy(vetor, vetorOrdenado, 10);

        // Ordenação do vetor auxiliar (Bubble Sort)
        bool trocou;
        do
        {
            trocou = false;
            for (int i = 0; i < 9; i++)
            {
                if (vetorOrdenado[i] > vetorOrdenado[i + 1])
                {
                    // Troca os elementos de posição
                    int temp = vetorOrdenado[i];
                    vetorOrdenado[i] = vetorOrdenado[i + 1];
                    vetorOrdenado[i + 1] = temp;
                    trocou = true;
                }
            }
        } while (trocou);

        // Exibição do vetor ordenado
        Console.WriteLine("\nVetor em ordem crescente:");
        foreach (int numero in vetorOrdenado)
        {
            Console.Write($"{numero} ");
        }
    }
}
