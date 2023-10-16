namespace _101023_exercicioMatrizes1;

//1) Crie uma Matriz 5x3.Na primeira coluna, solicite que o usuário preencha.
//A 2ª coluna, some 10 aos elementos da 1ª coluna.
//Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

using System;

class Program
{
    static void Main()
    {
        // Criar a matriz 5x3
        int[,] matriz = new int[5, 3];

        // Preencher a primeira coluna da matriz com valores fornecidos pelo usuário
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o valor da {i + 1}ª linha, 1ª coluna: ");
            matriz[i, 0] = Convert.ToInt32(Console.ReadLine());
        }

        // Preencher a segunda coluna somando 10 aos elementos da primeira coluna
        for (int i = 0; i < 5; i++)
        {
            matriz[i, 1] = matriz[i, 0] + 10;
        }

        // Preencher a terceira coluna com o dobro dos elementos da primeira coluna
        for (int i = 0; i < 5; i++)
        {
            matriz[i, 2] = matriz[i, 0] * 2;
        }

        // Exibir a matriz resultante
        Console.WriteLine("Matriz resultante:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine(); // Para manter a janela aberta até que o usuário pressione Enter
    }
}