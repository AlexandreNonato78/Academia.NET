namespace _091023_exercicioVetores7;
//7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares.Exemplo:
//a.lê: 		|7|40|3|9|21|0|63|31|7|22|
//b.escreve: 	|40|0|22|7|3|9|21|63|31|7|

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

        // Escrevendo os números pares
        Console.WriteLine("\nNúmeros pares:");
        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                Console.Write($"{vetor[i]} ");
            }
        }

        // Escrevendo os números ímpares
        Console.WriteLine("\nNúmeros ímpares:");
        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                Console.Write($"{vetor[i]} ");
            }
        }
    }
}
