namespace _101023_exercicioMatrizes3;

using System;
class Program
{
    static void Main()
    {
        // Criar a matriz 4x4
        int[,] matriz = new int[4, 4];

        // Preencher a matriz com valores fornecidos pelo usuário
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Digite o valor da {i + 1}ª linha, {j + 1}ª coluna: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Exibir os elementos da diagonal principal
        Console.WriteLine("Elementos da diagonal principal:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }

        Console.ReadLine(); // Para manter a janela aberta até que o usuário pressione Enter
    }
}