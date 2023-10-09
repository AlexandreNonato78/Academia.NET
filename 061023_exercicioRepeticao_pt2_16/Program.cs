namespace _061023_exercicioRepeticao_pt2_16;
//16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
//multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
//(N*3; N*3*3; N*3*3*3; etc).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número N (menor ou igual a 50): ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 50)
        {
            int produto = N;
            int contador = 1;

            while (produto < 250)
            {
                Console.WriteLine($"Produto {contador}: {produto}");
                produto *= 3;
                contador++;
            }
        }
        else
        {
            Console.WriteLine("Número N deve ser menor ou igual a 50.");
        }
    }
}
