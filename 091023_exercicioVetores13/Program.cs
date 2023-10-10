namespace _091023_exercicioVetores13;

//13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8.
//O vetor terá no máximo 100 posições.Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

using System;

class Program
{
    static void Main()
    {
        const int tamanhoMaximo = 100;
        int[] vetor = new int[tamanhoMaximo];
        int contador2 = 0, contador4 = 0, contador8 = 0;
        int posicao = 0;

        Console.WriteLine("Digite números inteiros e positivos. Digite -1 para encerrar ou quando atingir 100 posições.");

        while (posicao < tamanhoMaximo)
        {
            Console.Write($"Digite o {posicao + 1}º número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == -1)
            {
                break;
            }

            if (numero == 2)
            {
                contador2++;
            }
            else if (numero == 4)
            {
                contador4++;
            }
            else if (numero == 8)
            {
                contador8++;
            }

            vetor[posicao] = numero;
            posicao++;
        }

        Console.WriteLine($"Quantidade de vezes que o número 2 aparece: {contador2}");
        Console.WriteLine($"Quantidade de vezes que o número 4 aparece: {contador4}");
        Console.WriteLine($"Quantidade de vezes que o número 8 aparece: {contador8}");
    }
}
