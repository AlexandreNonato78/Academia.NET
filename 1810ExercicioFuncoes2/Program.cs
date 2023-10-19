namespace _1810ExercicioFuncoes2
{
    //2) Fazer programa que tenha duas funções.
    //i) para ler um vetor de 10 elementos(variável global) e
    //ii) para verificar e apresentar a quantidade de elementos pares que este vetor possui.

    using System;

    class Program
    {
        static int[] vetor = new int[10]; // Variável global para armazenar o vetor

        static void Main()
        {
            LerVetor(); // Chame a primeira função para ler o vetor

            int quantidadePares = ContarElementosPares(); // Chame a segunda função para contar os elementos pares

            Console.WriteLine("Vetor lido:");
            ImprimirVetor();

            Console.WriteLine($"Quantidade de elementos pares: {quantidadePares}");
        }

        static void LerVetor()
        {
            Console.WriteLine("Digite os 10 elementos do vetor:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int elemento))
                {
                    vetor[i] = elemento;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Insira um número válido.");
                    i--; // Para permitir a entrada correta
                }
            }
        }

        static int ContarElementosPares()
        {
            int quantidadePares = 0;
            foreach (int elemento in vetor)
            {
                if (elemento % 2 == 0)
                {
                    quantidadePares++;
                }
            }
            return quantidadePares;
        }

        static void ImprimirVetor()
        {
            foreach (int elemento in vetor)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
    }


}