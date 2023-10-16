namespace _101023_exercicioMatrizes17;

//17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,
//o menor elemento da linha onde se encontra o maior elemento da matriz.Escreva também a linha e a coluna onde foi encontrado.
using System;

class Program
{
    static void Main()
    {
        int linhas = 10;
        int colunas = 10;

        int[,] matriz = new int[linhas, colunas];

        Console.WriteLine("Digite os valores da matriz 10x10:");

        // Preencha a matriz
        PreencherMatriz(matriz, linhas, colunas);

        // Encontre o maior elemento da matriz e sua posição
        int maiorElemento = int.MinValue;
        int linhaMaior = 0;
        int colunaMaior = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > maiorElemento)
                {
                    maiorElemento = matriz[i, j];
                    linhaMaior = i;
                    colunaMaior = j;
                }
            }
        }

        // Encontre o elemento minimax (menor elemento na linha do maior elemento)
        int elementoMinimax = int.MaxValue;
        int colunaMinimax = 0;

        for (int j = 0; j < colunas; j++)
        {
            if (matriz[linhaMaior, j] < elementoMinimax)
            {
                elementoMinimax = matriz[linhaMaior, j];
                colunaMinimax = j;
            }
        }

        Console.WriteLine($"O maior elemento da matriz é {maiorElemento} (na linha {linhaMaior}, coluna {colunaMaior}).");
        Console.WriteLine($"O elemento minimax é {elementoMinimax} (na linha {linhaMaior}, coluna {colunaMinimax}).");
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
}
