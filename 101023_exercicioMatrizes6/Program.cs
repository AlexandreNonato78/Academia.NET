namespace _101023_exercicioMatrizes6;

//6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
//Random random = new Random();
//int randomNumber = random.Next(0, 100);

using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 4];
        Random random = new Random();
        int maiorNumero = int.MinValue;

        Console.WriteLine("Matriz 4x4 com valores aleatórios entre 0 e 9:");

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = random.Next(0, 10);
                Console.Write(matriz[i, j] + " ");

                // Verifica e atualiza o maior número
                if (matriz[i, j] > maiorNumero)
                {
                    maiorNumero = matriz[i, j];
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nO maior número na matriz é: " + maiorNumero);
    }
}
