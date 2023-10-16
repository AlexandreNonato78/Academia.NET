namespace _101023_exercicioMatrizes8;

//8) Ler uma matriz com 4x4 de inteiros e
//mostrar os números na ordem direta e inversa a que foram lidos.

using System;

class Program
{
    static void Main()
    {
        int linhas = 4;
        int colunas = 4;

        int[,] matriz = new int[linhas, colunas];

        Console.WriteLine("Digite os elementos da matriz 4x4:");

        // Preencha a matriz
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz na ordem direta:");

        // Mostra a matriz na ordem direta
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMatriz na ordem inversa:");

        // Mostra a matriz na ordem inversa
        for (int i = linhas - 1; i >= 0; i--)
        {
            for (int j = colunas - 1; j >= 0; j--)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
