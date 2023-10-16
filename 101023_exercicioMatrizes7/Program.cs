
namespace _101023_exercicioMatrizes7;
//7) Leia duas matrizes A e B com 3x3 elementos.Construir uma matriz C,
//onde cada elemento de C é a subtração do elemento correspondente de A com B.

using System;

class Program
{
    static void Main()
    {
        int linhas = 3;
        int colunas = 3;

        int[,] matrizA = new int[linhas, colunas];
        int[,] matrizB = new int[linhas, colunas];
        int[,] matrizC = new int[linhas, colunas];

        Console.WriteLine("Preencha a matriz A:");
        PreencherMatriz(matrizA, linhas, colunas);

        Console.WriteLine("Preencha a matriz B:");
        PreencherMatriz(matrizB, linhas, colunas);

        // Subtrai as matrizes A e B para obter a matriz C
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
            }
        }

        Console.WriteLine("Matriz C (Resultado da subtração de A e B):");
        ImprimirMatriz(matrizC, linhas, colunas);
    }

    // Função para preencher uma matriz
    static void PreencherMatriz(int[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    // Função para imprimir uma matriz
    static void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
