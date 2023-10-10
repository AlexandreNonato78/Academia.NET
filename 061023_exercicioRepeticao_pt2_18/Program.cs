namespace _061023_exercicioRepeticao_pt2_18;

//18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer
//elevada a um expoente qualquer, ou seja, NM.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a base (N): ");
        double baseN = double.Parse(Console.ReadLine());

        Console.Write("Digite o expoente (M): ");
        int expoenteM = int.Parse(Console.ReadLine());

        double resultado = Math.Pow(baseN, expoenteM);

        Console.WriteLine($"O valor de {baseN}^{expoenteM} é igual a {resultado}");
    }
}
