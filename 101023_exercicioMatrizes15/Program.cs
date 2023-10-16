namespace _101023_exercicioMatrizes15;

//15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

using System;

class Program
{
    static void Main()
    {
        int linhas = 4;
        int colunas = 4;

        int[,] matriz1 = new int[linhas, colunas];
        int[,] matriz2 = new int[linhas, colunas];
        int[,] matrizResultado = new int[linhas, colunas];

        Console.WriteLine("Digite os valores da primeira matriz 4x4:");

        // Preencha a primeira matriz
        PreencherMatriz(matriz1, linhas, colunas);

        Console.WriteLine("Digite os valores da segunda matriz 4x4:");

        // Preencha a segunda matriz
        PreencherMatriz(matriz2, linhas, colunas);

        // Realize a soma das matrizes
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizResultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        Console.WriteLine("Matriz Resultante (soma das duas matrizes):");

        // Mostra a matriz resultante
        ImprimirMatriz(matrizResultado, linhas, colunas);
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
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
