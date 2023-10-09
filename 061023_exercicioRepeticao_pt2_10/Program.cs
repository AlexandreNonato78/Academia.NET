namespace _061023_exercicioRepeticao_pt2_10;
//10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
//Número de pessoas do sexo masculino.
//Número de pessoas do sexo feminino.
//Número de pessoas com idade inferior a 30 anos.
//Número de pessoas com idade superior a 60 anos.
//Média de idade das mulheres.

using System;

class Program
{
    static void Main()
    {
        int pessoasMasculino = 0;
        int pessoasFeminino = 0;
        int pessoasMenos30Anos = 0;
        int pessoasMais60Anos = 0;
        int totalIdadeMulheres = 0;
        int totalMulheres = 0;

        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine($"Pessoa {i}:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sexo (M/F): ");
            char sexo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (sexo == 'M')
            {
                pessoasMasculino++;
            }
            else if (sexo == 'F')
            {
                pessoasFeminino++;
                totalIdadeMulheres += idade;
                totalMulheres++;
            }

            if (idade < 30)
            {
                pessoasMenos30Anos++;
            }
            else if (idade > 60)
            {
                pessoasMais60Anos++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Número de pessoas do sexo masculino: {pessoasMasculino}");
        Console.WriteLine($"Número de pessoas do sexo feminino: {pessoasFeminino}");
        Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {pessoasMenos30Anos}");
        Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {pessoasMais60Anos}");

        double mediaIdadeMulheres = totalIdadeMulheres / (double)totalMulheres;
        Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres:F2}");
    }
}
