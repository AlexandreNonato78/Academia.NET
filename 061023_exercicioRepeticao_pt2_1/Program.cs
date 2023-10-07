using System.ComponentModel;
using System.Drawing;

//1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
//(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
//Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

//Exemplo:
//Digite um número inteiro positivo: -8
//Valor incorreto!
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.

using System;

class Program
{
    static void Main()
    {
        int numero = 0; // Inicialize com um valor padrão
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.Write("Digite um número inteiro positivo: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero) && numero > 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Valor incorreto! O número deve ser inteiro positivo.");
            }
        }

        Console.WriteLine($"Número digitado: {numero}");
        Console.Write("Números inteiros pares entre 1 e " + numero + ": ");

        for (int i = 2; i <= numero; i += 2)
        {
            Console.Write(i);

            if (i < numero - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}
