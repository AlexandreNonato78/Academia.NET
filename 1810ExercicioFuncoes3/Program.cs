namespace _1810ExercicioFuncoes3
    //3) Desenvolva uma função que calcule a média de três números fornecidos como argumentos.
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite três números para calcular a média:");

            double numero1 = LerNumero("Digite o primeiro número: ");
            double numero2 = LerNumero("Digite o segundo número: ");
            double numero3 = LerNumero("Digite o terceiro número: ");

            double media = CalcularMedia(numero1, numero2, numero3);

            Console.WriteLine($"A média dos números é: {media}");
        }

        static double LerNumero(string mensagem)
        {
            Console.Write(mensagem);
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                Console.Write(mensagem);
            }
            return numero;
        }

        static double CalcularMedia(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }
    }
}