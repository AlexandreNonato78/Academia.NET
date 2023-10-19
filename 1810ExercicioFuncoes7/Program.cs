namespace _1810ExercicioFuncoes7

    //7) Crie uma função que determine se um número é primo ou não.
{
        using System;

class Program
    {
        static void Main()
        {
            Console.Write("Digite um número inteiro positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 1)
            {
                if (EhPrimo(numero))
                {
                    Console.WriteLine($"{numero} é um número primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} não é um número primo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo maior que 1.");
            }
        }

        static bool EhPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false; // Números menores ou iguais a 1 não são primos
            }

            if (numero <= 3)
            {
                return true; // 2 e 3 são primos
            }

            if (numero % 2 == 0 || numero % 3 == 0)
            {
                return false; // Números divisíveis por 2 ou 3 não são primos
            }

            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                {
                    return false; // Números divisíveis por outros valores não são primos
                }
            }

            return true; // Se não for divisível por nenhum valor anterior, é primo
        }
    }

}