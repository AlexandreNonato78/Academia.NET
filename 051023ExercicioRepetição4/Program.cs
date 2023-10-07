namespace _051023ExercicioRepetição4;
//4. Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
//elevado na y sem utilizar a função pow.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de y: ");
        int y = int.Parse(Console.ReadLine());

        double resultado = 1.0;

        for (int i = 1; i <= Math.Abs(y); i++)
        {
            resultado *= x;
        }

        if (y < 0)
        {
            resultado = 1.0 / resultado;
        }

        Console.WriteLine("O resultado de " + x + " elevado a " + y + " é: " + resultado);
    }
}
