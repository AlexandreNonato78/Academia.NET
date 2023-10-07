using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace _061023_exercicioRepeticao_pt2_2;

//2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
//informar um outro número.Caso positivo, o programa em VS deve ser repetido.

//Exemplo:
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.

//Deseja informar outro número (s/n)? S

//Digite um número inteiro positivo: 12
//Numero digitado: 20
//Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
//Deseja informar outro número(s/n)? N

using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
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

            Console.Write("Deseja informar outro número (s/n)? ");
            char resposta = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (resposta != 's' && resposta != 'S')
            {
                continuar = false;
            }
        }
    }
}
