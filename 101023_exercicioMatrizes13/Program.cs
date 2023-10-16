using System.Net;

namespace _101023_exercicioMatrizes13;

//13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5). Mostre a matriz e verifique se
//a soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária.
using System;

class Program
{
    static void Main()
    {
        int ordem = 5;
        int[,] matriz = new int[ordem, ordem];

        Console.WriteLine("Digite os elementos da matriz 5x5:");

        // Preencha a matriz
        for (int i = 0; i < ordem; i++)
        {
            for (int j = 0; j < ordem; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Matriz digitada:");

        // Mostra a matriz digitada
        for (int i = 0; i < ordem; i++)
        {
            for (int j = 0; j < ordem; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Verifica se a soma da diagonal principal é igual à soma da diagonal secundária
        int somaDiagonalPrincipal = 0;
        int somaDiagonalSecundaria = 0;

        for (int i = 0; i < ordem; i++)
        {
            somaDiagonalPrincipal += matriz[i, i];
            somaDiagonalSecundaria += matriz[i, ordem - 1 - i];
        }

        if (somaDiagonalPrincipal == somaDiagonalSecundaria)
        {
            Console.WriteLine("A soma da diagonal principal é igual à soma da diagonal secundária.");
        }
        else
        {
            Console.WriteLine("A soma da diagonal principal não é igual à soma da diagonal secundária.");
        }
    }
}