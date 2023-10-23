namespace _1910ExercicioFuncoes2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Informe o valor para a posição {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            string escolha;
            do
            {
                Console.Write("Deseja calcular a média dos valores pares ou ímpares? (pares/ímpares): ");
                escolha = Console.ReadLine().ToLower();
            } while (escolha != "pares" && escolha != "ímpares");

            double media = CalcularMedia(vetor, escolha == "pares");
            Console.WriteLine($"A média dos valores {escolha} é {media:F2}");

            // Exibir o vetor escolhido
            if (escolha == "pares")
            {
                Console.WriteLine("Valores pares:");
                ExibirVetorFiltrado(vetor, true);
            }
            else
            {
                Console.WriteLine("Valores ímpares:");
                ExibirVetorFiltrado(vetor, false);
            }
        }

        static void ExibirVetorFiltrado(int[] vetor, bool considerarPares)
        {
            foreach (int valor in vetor)
            {
                if ((considerarPares && valor % 2 == 0) || (!considerarPares && valor % 2 != 0))
                {
                    Console.Write($"{valor} ");
                }
            }
            Console.WriteLine();
        }

        static double CalcularMedia(int[] vetor, bool considerarPares)
        {
            int soma = 0;
            int count = 0;

            foreach (int valor in vetor)
            {
                if ((considerarPares && valor % 2 == 0) || (!considerarPares && valor % 2 != 0))
                {
                    soma += valor;
                    count++;
                }
            }

            if (count > 0)
            {
                return (double)soma / count;
            }
            else
            {
                return 0.0;
            }
        }
    }

}