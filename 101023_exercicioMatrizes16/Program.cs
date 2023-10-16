namespace _101023_exercicioMatrizes16;
//16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
//Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

using System;

class Program
{
    static void Main()
    {
        int linhasOrigem = 3;
        int colunasOrigem = 4;

        int[,] matrizOrigem = new int[linhasOrigem, colunasOrigem];
        int[,] matrizTransposta = new int[colunasOrigem, linhasOrigem];

        Console.WriteLine("Digite os valores da matriz original 3x4:");

        // Preencha a matriz original
        PreencherMatriz(matrizOrigem, linhasOrigem, colunasOrigem);

        // Transpor a matriz original
        for (int i = 0; i < linhasOrigem; i++)
        {
            for (int j = 0; j < colunasOrigem; j++)
            {
                matrizTransposta[j, i] = matrizOrigem[i, j];
            }
        }

        Console.WriteLine("Matriz Original:");
        ImprimirMatriz(matrizOrigem, linhasOrigem, colunasOrigem);

        Console.WriteLine("Matriz Transposta (4x3):");
        ImprimirMatriz(matrizTransposta, colunasOrigem, linhasOrigem);
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
