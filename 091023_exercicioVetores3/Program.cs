namespace _091023_exercicioVetores3;
// 3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então
// mostre na tela o índice da posição dos valores correspondentes a números primos.

using System;

class Program
{
    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;

        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        // Declaração do vetor com 20 elementos
        int[] vetor = new int[20];

        // Leitura dos valores para o vetor
        Console.WriteLine("Digite os valores para o vetor:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Encontrando e exibindo os índices das posições com números primos
        Console.WriteLine("\nÍndices das posições com números primos:");
        for (int i = 0; i < 20; i++)
        {
            if (EhPrimo(vetor[i]))
            {
                Console.WriteLine($"Posição {i}: {vetor[i]}");
            }
        }
    }
}
