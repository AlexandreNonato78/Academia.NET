namespace _051023ExercicioRepetição5;
//5. Escreva um algoritmo para calcular o fatorial de um número.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para calcular o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        long fatorial = 1;

        for (int i = 1; i <= n; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine("O fatorial de " + n + " é: " + fatorial);
    }
}
