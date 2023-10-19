namespace _1810ExercicioFuncoes6
    //6) Escreva uma função que calcule a média de um vetor de 10 números.
{
    using System;

    class Program
    {
        static void Main()
        {
            double[] vetor = new double[10];

            // Preencha o vetor com valores (pode ser manualmente ou lendo do usuário)
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double valor))
                {
                    vetor[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                    i--; // Tente novamente para este índice
                }
            }

            double media = CalcularMedia(vetor);
            Console.WriteLine($"A média dos valores no vetor é: {media}");
        }

        static double CalcularMedia(double[] vetor)
        {
            double soma = 0;
            foreach (double valor in vetor)
            {
                soma += valor;
            }

            return soma / vetor.Length;
        }
    }

}