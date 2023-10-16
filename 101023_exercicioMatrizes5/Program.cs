namespace _101023_exercicioMatrizes5;

//5) Leia duas matrizes 2x3 de números double. 
//Imprima a soma destas duas matrizes.

using System;

class Program
{
    static void Main()
    {
        int linhas = 2;
        int colunas = 3;

        double[,] matriz1 = new double[linhas, colunas];
        double[,] matriz2 = new double[linhas, colunas];
        double[,] matrizSoma = new double[linhas, colunas];

        // Preencha a primeira matriz
        Console.WriteLine("Preencha a primeira matriz:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz1[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Preencha a segunda matriz
        Console.WriteLine("Preencha a segunda matriz:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz2[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Calcule a matriz de soma
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        // Imprima a matriz de soma
        Console.WriteLine("\nMatriz de Soma:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matrizSoma[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
