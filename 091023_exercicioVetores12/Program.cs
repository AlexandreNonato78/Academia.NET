namespace _091023_exercicioVetores12;
 //12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário,
 //existe no vetor.Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".
using System;

class Program
{
    static void Main()
    {
        // Declaração de um vetor com 10 posições
        int[] vetor = new int[10];

        // Leitura dos valores para o vetor
        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Leitura do número fornecido pelo usuário
        Console.Write("Digite um número para verificar se existe no vetor: ");
        int numeroProcurado = int.Parse(Console.ReadLine());

        // Verificação da existência do número no vetor
        bool numeroEncontrado = false;

        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] == numeroProcurado)
            {
                Console.WriteLine($"O número {numeroProcurado} foi encontrado na posição {i} do vetor.");
                numeroEncontrado = true;
            }
        }

        if (!numeroEncontrado)
        {
            Console.WriteLine("O número fornecido não existe no vetor!");
        }
    }
}
