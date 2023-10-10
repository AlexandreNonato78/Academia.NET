namespace _091023_exercicioVetores14;
//14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.
//Se o código for zero, termine o algoritmo.Se o código for 1, mostre o vetor na ordem em que foi lido.
//Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

using System;

class Program
{
    static void Main()
    {
        const int tamanhoVetor = 50;
        int[] vetor = new int[tamanhoVetor];
        int codigo;

        Console.WriteLine("Digite o código (0 para sair, 1 para mostrar o vetor na ordem, 2 para mostrar o vetor na ordem inversa):");

        do
        {
            Console.Write("Código: ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                Console.WriteLine("\nVetor na ordem original:");
                MostrarVetor(vetor);
            }
            else if (codigo == 2)
            {
                Console.WriteLine("\nVetor na ordem inversa:");
                MostrarVetorInverso(vetor);
            }
            else if (codigo != 0)
            {
                Console.WriteLine("Código inválido. Digite 0, 1 ou 2.");
            }

        } while (codigo != 0);
    }

    static void MostrarVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }

    static void MostrarVetorInverso(int[] vetor)
    {
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}
