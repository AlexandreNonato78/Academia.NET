namespace _101023_exercicioMatrizes14;
//14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal
//(da esquerda para a direita) são os mesmos da diagonal secundária(direita pra esquerda).

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

        // Verifica se os elementos da diagonal principal são iguais aos da diagonal secundária
        bool diagonaisIguais = true;
        for (int i = 0; i < ordem; i++)
        {
            if (matriz[i, i] != matriz[i, ordem - 1 - i])
            {
                diagonaisIguais = false;
                break;
            }
        }

        if (diagonaisIguais)
        {
            Console.WriteLine("Os elementos da diagonal principal são iguais aos da diagonal secundária.");
        }
        else
        {
            Console.WriteLine("Os elementos da diagonal principal não são iguais aos da diagonal secundária.");
        }
    }
}
