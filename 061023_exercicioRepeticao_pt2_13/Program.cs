namespace _061023_exercicioRepeticao_pt2_13;
//13. Elaborar um programa que apresente o somatório dos valores pares existentes
//entre 1 e 500.
using System;

class Program
{
    static void Main()
    {
        int somatorio = 0;

        for (int i = 2; i <= 500; i += 2)
        {
            somatorio += i;
        }

        Console.WriteLine($"O somatório dos valores pares entre 1 e 500 é: {somatorio}");
    }
}
