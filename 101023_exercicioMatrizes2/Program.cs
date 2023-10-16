namespace _101023_exercicioMatrizes2;

//2) Solicite ao usuário, preencher uma Matriz 3x3

//Informe ao usuário:
//* A soma dos elementos de cada linha
//	-Ex: Linha 1: 30
//	     Linha 2: 17
//* A soma dos elementos de cada coluna
//	-Ex: Coluna 1: 23
//	     Coluna 2: 36

using System;

class Program
{
    static void Main()
    {
        // Criar a matriz 3x3
        int[,] matriz = new int[3, 3];

        // Preencher a matriz com valores fornecidos pelo usuário
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor da {i + 1}ª linha, {j + 1}ª coluna: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Calcular e exibir a soma dos elementos de cada linha
        for (int i = 0; i < 3; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < 3; j++)
            {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Soma dos elementos da linha {i + 1}: {somaLinha}");
        }

        // Calcular e exibir a soma dos elementos de cada coluna
        for (int j = 0; j < 3; j++)
        {
            int somaColuna = 0;
            for (int i = 0; i < 3; i++)
            {
                somaColuna += matriz[i, j];
            }
            Console.WriteLine($"Soma dos elementos da coluna {j + 1}: {somaColuna}");
        }

        Console.ReadLine(); // Para manter a janela aberta até que o usuário pressione Enter
    }
}

