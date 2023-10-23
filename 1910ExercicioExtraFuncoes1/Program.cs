namespace _1910ExercicioFuncoes1
//1 - Na teoria dos Sistemas, define-se como elemento minimax de uma matriz, o menor elemento da linha em que se encontra o maior elemento da matriz.
//Escreva um programa, em C#, que lê uma matriz [10 X 10] e
//em uma função encontre e mostre o elemento minimax e sua posição na matriz.

{
    using System;

    class Program
    {
        static void Main()
        {
            int[,] matriz = new int[10, 10];

            // Preencha a matriz com valores
            PreencherMatriz(matriz);

            // Encontre o elemento minimax e sua posição
            EncontrarMinimax(matriz, out int minimaxElemento, out int linha, out int coluna);

            // Mostre o resultado
            Console.WriteLine("Matriz 10x10:");
            ImprimirMatriz(matriz);

            Console.WriteLine($"O elemento minimax é {minimaxElemento} na posição ({linha},{coluna}).");
        }

        static void PreencherMatriz(int[,] matriz)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = random.Next(1, 101); // Preenche a matriz com valores aleatórios de 1 a 100
                }
            }
        }

        static void EncontrarMinimax(int[,] matriz, out int minimaxElemento, out int linha, out int coluna)
        {
            minimaxElemento = int.MaxValue;
            linha = 0;
            coluna = 0;
            int maxElemento = int.MinValue;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] > maxElemento)
                    {
                        maxElemento = matriz[i, j];
                        linha = i;
                        coluna = j;
                    }
                }
            }

            for (int j = 0; j < 10; j++)
            {
                if (matriz[linha, j] < minimaxElemento)
                {
                    minimaxElemento = matriz[linha, j];
                    coluna = j;
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}