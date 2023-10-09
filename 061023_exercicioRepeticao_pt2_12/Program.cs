using System.Runtime.ConstrainedExecution;

namespace _061023_exercicioRepeticao_pt2_12;
//12. Apresentar o total da soma dos cem primeiros números inteiros.
using System;

class Program
{
    static void Main()
    {
        int n = 100;
        int soma = (n * (n + 1)) / 2;
        Console.WriteLine($"A soma dos {n} primeiros números inteiros é: {soma}");
    }
}
