namespace _091023_exercicioVetores6;
//6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura.Exemplo:
//a.lê: 		|7|40|3|9|21|0|63|31|7|22|
//b.escreve: 	|22|7|31|63|0|21|9|3|40|7|

using System;

class Program
{
    static void Main()
    {
        // Declaração de um vetor com 10 elementos
        int[] vetor = new int[10];

        // Leitura dos valores para o vetor
        Console.WriteLine("Digite 10 números:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Escrevendo os números na ordem contrária
        Console.WriteLine("\nNúmeros na ordem contrária à ordem de leitura:");
        for (int i = 9; i >= 0; i--)
        {
            Console.Write($"{vetor[i]} ");
        }
    }
}
