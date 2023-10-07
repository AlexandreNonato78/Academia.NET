﻿namespace _061023_exercicioRepeticao_pt2_3;
using System;

//3. Fazer um laço(repetição) que fique solicitando números ao usuário.
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo. 

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Digite um número (ou 0 para sair): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Programa encerrado.");
                break; // Sai do loop quando o usuário digita 0
            }

            // Verificar se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é um número par.");
            }
            else
            {
                Console.WriteLine($"{numero} é um número ímpar.");
            }

            // Verificar se o número é primo
            if (EhPrimo(numero))
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }
    }

    // Função para verificar se um número é primo
    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
