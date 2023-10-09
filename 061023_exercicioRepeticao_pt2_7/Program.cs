using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp2;

//7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
//A cada solicitação, teste se o usuário informou um valor válido.
//Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número),
//informe que ele está incorreto e saia do programa em VS.
//Se o nome for lido corretamente, solicite a idade.Se ela for incorreta (menor ou igual a zero),
//informe que está errada e saia.Se estiver correta, solicite o salário.
//Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia.
//Se estiver correto, mostre todos os valores lidos.

    using System;

class Program
{
    static void Main()
    {
        string nome = "";
        int idade = 0;
        double salario = 0;
        bool entradaValida = false;

        // Solicitar e validar o nome
        while (!entradaValida)
        {
            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nome) && !nome.All(char.IsDigit))
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Nome incorreto! O nome não pode estar em branco ou ser um número.");
            }
        }

        // Solicitar e validar a idade
        entradaValida = false;
        while (!entradaValida)
        {
            Console.Write("Informe a idade: ");
            string entradaIdade = Console.ReadLine();

            if (int.TryParse(entradaIdade, out idade) && idade > 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Idade incorreta! A idade deve ser um número inteiro maior que zero.");
            }
        }

        // Solicitar e validar o salário
        entradaValida = false;
        while (!entradaValida)
        {
            Console.Write("Informe o salário: ");
            string entradaSalario = Console.ReadLine();

            if (double.TryParse(entradaSalario, out salario) && salario > 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Salário incorreto! O salário deve ser um número maior que zero.");
            }
        }

        // Exibir os valores lidos
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Salário: R${salario:F2}");
    }
}
