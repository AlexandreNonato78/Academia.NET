namespace _061023_exercicioRepeticao_pt2_17;
//17. Apresentar os quadrados dos números inteiros de 15 a 200.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quadrados dos números inteiros de 15 a 200:");

        for (int i = 15; i <= 200; i++)
        {
            int quadrado = i * i;
            Console.WriteLine($"O quadrado de {i} é {quadrado}");
        }
    }
}
