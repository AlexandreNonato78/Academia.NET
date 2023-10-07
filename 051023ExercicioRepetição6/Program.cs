namespace _051023ExercicioRepetição6;

//6. Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações
//aplicadas para aquela turma.Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final
//(média das notas das avaliações).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de alunos na turma: ");
        int numeroDeAlunos = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de avaliações aplicadas: ");
        int quantidadeDeAvaliacoes = int.Parse(Console.ReadLine());

        for (int aluno = 1; aluno <= numeroDeAlunos; aluno++)
        {
            double somaDasNotas = 0;

            for (int avaliacao = 1; avaliacao <= quantidadeDeAvaliacoes; avaliacao++)
            {
                Console.Write("Digite a nota da avaliação " + avaliacao + " para o aluno " + aluno + ": ");
                double nota = double.Parse(Console.ReadLine());

                somaDasNotas += nota;
            }

            double media = somaDasNotas / quantidadeDeAvaliacoes;
            Console.WriteLine("A média das notas para o aluno " + aluno + " é: " + media.ToString("F2"));
        }
    }
}
