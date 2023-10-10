namespace _061023_exercicioRepeticao_pt2_19;

//19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
//coletando dados sobre o salário e número de filhos.A prefeitura deseja saber:
//a) média do salário da população;
//b) média do número de filhos;
//c) maior salário;
//d) percentual de pessoas com salário até R$ 100,00.
//O final da leitura de dados se dará com a entrada de um salário negativo.

using System;

class Program
{
    static void Main()
    {
        double salario;
        int numeroFilhos;
        double somaSalarios = 0;
        int somaFilhos = 0;
        double maiorSalario = double.MinValue;
        int totalPessoas = 0;
        int pessoasAte100 = 0;

        Console.WriteLine("Digite os dados dos habitantes (salário negativo para encerrar):");

        while (true)
        {
            Console.Write("Salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 0)
            {
                break;
            }

            Console.Write("Número de filhos: ");
            numeroFilhos = int.Parse(Console.ReadLine());

            somaSalarios += salario;
            somaFilhos += numeroFilhos;
            totalPessoas++;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }

            if (salario <= 100)
            {
                pessoasAte100++;
            }
        }

        if (totalPessoas > 0)
        {
            double mediaSalario = somaSalarios / totalPessoas;
            double mediaFilhos = (double)somaFilhos / totalPessoas;
            double percentualAte100 = (double)pessoasAte100 / totalPessoas * 100;

            Console.WriteLine($"Média do salário da população: {mediaSalario:F2}");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
            Console.WriteLine($"Maior salário: {maiorSalario:F2}");
            Console.WriteLine($"Percentual de pessoas com salário até R$ 100,00: {percentualAte100:F2}%");
        }
        else
        {
            Console.WriteLine("Nenhum dado válido foi inserido.");
        }
    }
}
