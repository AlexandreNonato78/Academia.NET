namespace _091023_exercicioVetores15;

//15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor,
//e copie estes conteúdos para outro vetor, invertendo sua ordem.Assim, o valor do primeiro elemento do primeiro vetor
//deve ser o valor do último elemento do segundo vetor, por exemplo.
//Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

using System;

class Program
{
    static void Main()
    {
        int[] vetorOriginal = new int[20];
        int[] vetorInvertido = new int[20];

        // Leitura dos valores para o vetor original
        Console.WriteLine("Digite 20 números inteiros:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetorOriginal[i] = int.Parse(Console.ReadLine());
        }

        // Copiar e inverter os valores para o vetor invertido
        for (int i = 0; i < 20; i++)
        {
            vetorInvertido[i] = vetorOriginal[19 - i];
        }

        // Mostrar os conteúdos dos vetores
        Console.WriteLine("\nVetor Original:");
        MostrarVetor(vetorOriginal);

        Console.WriteLine("\nVetor Invertido:");
        MostrarVetor(vetorInvertido);
    }

    static void MostrarVetor(int[] vetor)
    {
        foreach (int numero in vetor)
        {
            Console.Write(numero + " ");
        }
    }
}
