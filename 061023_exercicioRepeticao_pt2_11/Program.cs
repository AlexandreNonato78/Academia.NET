using System.Runtime.Intrinsics.X86;

namespace _061023_exercicioRepeticao_pt2_11;

//11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
//a média aritmética da turma e a quantidade de alunos da turma.Usar -1 para encerrar a leitura.

using System;

class Program
{
    static void Main()
    {
        double nota;
        double notaMaxima = double.MinValue;
        double notaMinima = double.MaxValue;
        double somaDasNotas = 0;
        int quantidadeDeAlunos = 0;

        Console.WriteLine("Digite as notas dos alunos (-1 para encerrar):");

        while (true)
        {
            Console.Write("Digite a nota do aluno (ou -1 para encerrar): ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out nota))
            {
                if (nota == -1)
                {
                    break; // Encerra o loop quando -1 for inserido.
                }

                quantidadeDeAlunos++;
                somaDasNotas += nota;

                if (nota > notaMaxima)
                {
                    notaMaxima = nota;
                }

                if (nota < notaMinima)
                {
                    notaMinima = nota;
                }
            }
            else
            {
                Console.WriteLine("Nota inválida. Tente novamente.");
            }
        }

        if (quantidadeDeAlunos > 0)
        {
            double mediaDasNotas = somaDasNotas / quantidadeDeAlunos;

            Console.WriteLine($"Nota mais alta: {notaMaxima}");
            Console.WriteLine($"Nota mais baixa: {notaMinima}");
            Console.WriteLine($"Média aritmética da turma: {mediaDasNotas:F2}");
            Console.WriteLine($"Quantidade de alunos da turma: {quantidadeDeAlunos}");
        }
        else
        {
            Console.WriteLine("Nenhuma nota válida foi inserida.");
        }
    }
}
