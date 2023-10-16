namespace _101023_exercicioMatrizes11;

//11) Leia uma matriz A de tipo double de dimenção 3x3,
//crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

using System;

class Program
{
    static void Main()
    {
        int linhas = 3;
        int colunas = 3;

        double[,] matrizA = new double[linhas, colunas];
        double[,] matrizResultado = new double[linhas, colunas];

        Console.WriteLine("Preencha a matriz A:");

        // Preencha a matriz A
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matrizA[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Calcule a matriz resultado
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                double somaIndices = i + j + 2; // Soma dos índices (i, j) + 2 para evitar divisão por zero
                matrizResultado[i, j] = matrizA[i, j] / somaIndices;
            }
        }

        Console.WriteLine("Matriz Resultado (A / (i + j + 2)):");
        ImprimirMatriz(matrizResultado, linhas, colunas);
    }

    // Função para imprimir uma matriz
    static void ImprimirMatriz(double[,] matriz, int linhas, int colunas)
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
