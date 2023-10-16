namespace _101023_exercicioMatrizes10;
    //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos,
    //em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

using System;

class Program
{
    static void Main()
    {
        int linhas = 4;
        int colunas = 4;

        double[,] matrizA = new double[linhas, colunas];
        double[,] matrizB = new double[linhas, colunas];

        Console.WriteLine("Preencha a matriz A:");
        PreencherMatriz(matrizA, linhas, colunas);

        Console.WriteLine("Preencha a matriz B:");
        PreencherMatriz(matrizB, linhas, colunas);

        // Calcula a média dos elementos das matrizes A e B
        double mediaA = CalcularMedia(matrizA, linhas, colunas);
        double mediaB = CalcularMedia(matrizB, linhas, colunas);

        Console.WriteLine("A média da matriz A é: " + mediaA);
        Console.WriteLine("A média da matriz B é: " + mediaB);

        int abaixoMediaA = ContarAbaixoMedia(matrizA, linhas, colunas, mediaA);
        int abaixoMediaB = ContarAbaixoMedia(matrizB, linhas, colunas, mediaB);
        int acimaMediaA = ContarAcimaMedia(matrizA, linhas, colunas, mediaA);
        int acimaMediaB = ContarAcimaMedia(matrizB, linhas, colunas, mediaB);

        Console.WriteLine("Na matriz A, elementos abaixo da média: " + abaixoMediaA);
        Console.WriteLine("Na matriz B, elementos abaixo da média: " + abaixoMediaB);
        Console.WriteLine("Na matriz A, elementos acima da média: " + acimaMediaA);
        Console.WriteLine("Na matriz B, elementos acima da média: " + acimaMediaB);
    }

    // Função para preencher uma matriz
    static void PreencherMatriz(double[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    // Função para calcular a média dos elementos de uma matriz
    static double CalcularMedia(double[,] matriz, int linhas, int colunas)
    {
        double soma = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma += matriz[i, j];
            }
        }

        return soma / (linhas * colunas);
    }

    // Função para contar quantos elementos de uma matriz estão abaixo da média
    static int ContarAbaixoMedia(double[,] matriz, int linhas, int colunas, double media)
    {
        int contador = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] < media)
                {
                    contador++;
                }
            }
        }

        return contador;
    }

    // Função para contar quantos elementos de uma matriz estão acima da média
    static int ContarAcimaMedia(double[,] matriz, int linhas, int colunas, double media)
    {
        int contador = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > media)
                {
                    contador++;
                }
            }
        }

        return contador;
    }
}
