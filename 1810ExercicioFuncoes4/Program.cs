namespace _1810ExercicioFuncoes4
//4) Escreva uma função que calcule o fatorial de um número inteiro positivo.

{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Digite um número inteiro positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
            {
                long fatorial = CalcularFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é {fatorial}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo.");
            }
        }

        static long CalcularFatorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            long fatorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }

}