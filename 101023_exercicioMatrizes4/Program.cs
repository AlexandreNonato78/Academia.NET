namespace _101023_exercicioMatrizes4;
// 4) Popule uma matriz 5x5 e informe:
//-Quantos números são pares
//-Quantos números são impares
//-Quantos números são positivos
//-Quantos números são negativos
//-Quantos zeros existem!

using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;

        Console.WriteLine("Preencha a matriz 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());

                // Verifica se o número é par, ímpar, positivo, negativo ou zero
                if (matriz[i, j] % 2 == 0)
                    pares++;
                else
                    impares++;

                if (matriz[i, j] > 0)
                    positivos++;
                else if (matriz[i, j] < 0)
                    negativos++;
                else
                    zeros++;
            }
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Números pares: {pares}");
        Console.WriteLine($"Números ímpares: {impares}");
        Console.WriteLine($"Números positivos: {positivos}");
        Console.WriteLine($"Números negativos: {negativos}");
        Console.WriteLine($"Zeros: {zeros}");
    }
}
