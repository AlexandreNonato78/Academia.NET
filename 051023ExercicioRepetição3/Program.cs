namespace _051023ExercicioRepetição3;
//3. Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
//x lido utilizando laços de repetição, e mostre na tela.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para calcular a tabuada: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabuada de " + x + ":");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = x * i;
            Console.WriteLine(x + " x " + i + " = " + resultado);
        }
    }
}
