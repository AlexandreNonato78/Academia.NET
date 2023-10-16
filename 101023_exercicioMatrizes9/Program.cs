namespace _101023_exercicioMatrizes9;

//9) Leia uma matriz 3x3.Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.
//Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
using System;
class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Digite os elementos da matriz 3x3:");

        // Preencha a matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.Write("Digite um número para pesquisar na matriz: ");
        int numeroProcurado = Convert.ToInt32(Console.ReadLine());

        // Pesquise o número na matriz
        bool numeroExiste = false;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] == numeroProcurado)
                {
                    numeroExiste = true;
                    break; // Achou o número, sai do loop interno
                }
            }
            if (numeroExiste) // Se achou o número, sai do loop externo
                break;
        }

        if (numeroExiste)
        {
            Console.WriteLine("O número existe no vetor.");
        }
        else
        {
            Console.WriteLine("Número inexistente.");
        }
    }
}