namespace _101023_exercicioMatrizes12;

//12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida
//mostre na tela apenas os valores cuja soma dos índices(i+j) seja um número par.

using System;
class Program
{
    static void Main()
    {
        int linhas = 4;
        int colunas = 3;

        int[,] matriz = new int[linhas, colunas];

        Console.WriteLine("Preencha a matriz 4x3:");

        // Preencha a matriz
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Valores cuja soma dos índices (i+j) é par:");

        // Mostre os valores com soma de índices par
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.WriteLine($"Valor na posição [{i},{j}]: {matriz[i, j]}");
                }
            }
        }
    }
}
