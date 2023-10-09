namespace _061023_exercicioRepeticao_pt2_15;

//15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado
//ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
//Considerar nota 7,0 como mínima para aprovação.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite as 4 notas do aluno:");

        // Lê as notas do usuário
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double nota3 = double.Parse(Console.ReadLine());
        double nota4 = double.Parse(Console.ReadLine());

        // Define os pesos para cada nota
        double peso1 = 2;
        double peso2 = 1;
        double peso3 = 2;
        double peso4 = 4;

        // Calcula a média ponderada
        double mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3 + nota4 * peso4) / (peso1 + peso2 + peso3 + peso4);

        // Verifica se o aluno está aprovado ou reprovado
        if (mediaPonderada >= 7.0)
        {
            Console.WriteLine($"O aluno está APROVADO com média {mediaPonderada:F2}");
        }
        else
        {
            Console.WriteLine($"O aluno está REPROVADO com média {mediaPonderada:F2}");
        }
    }
}
