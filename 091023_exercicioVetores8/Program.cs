namespace _091023_exercicioVetores8;

//8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor.Exemplo:
//a.lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
//b.escreve: 	|3|5|6|7|9|10|14|. . .

using System;

class Program
{
    static void Main()
    {
        // Declaração de um vetor com 30 elementos
        double[] vetor = new double[30];

        // Leitura dos valores para o vetor
        Console.WriteLine("Digite 30 números reais:");
        for (int i = 0; i < 30; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        // Escrevendo a posição dos números menores que zero
        Console.WriteLine("\nPosição dos números menores que zero:");
        for (int i = 0; i < 30; i++)
        {
            if (vetor[i] < 0)
            {
                Console.Write($"{i + 1} ");
            }
        }
    }
}
