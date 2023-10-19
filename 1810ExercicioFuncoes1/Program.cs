namespace _1810ExercicioFuncoes1;
// 1) Fazer uma calculadora das 4 operações(soma, subtração, multiplicação e divisão).
// Para isso, precisaremos aceitar números com vírgula.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora das 4 Operações");
        Console.WriteLine("Selecione a operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 4)
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = LerNumero();

            Console.Write("Digite o segundo número: ");
            double numero2 = LerNumero();

            double resultado = 0;

            switch (opcao)
            {
                case 1: // Soma
                    resultado = numero1 + numero2;
                    break;
                case 2: // Subtração
                    resultado = numero1 - numero2;
                    break;
                case 3: // Multiplicação
                    resultado = numero1 * numero2;
                    break;
                case 4: // Divisão
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero.");
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Opção inválida. Por favor, escolha uma operação válida (1 a 4).");
        }
    }

    static double LerNumero()
    {
        double numero;
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
        }
        return numero;
    }
}
