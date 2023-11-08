//1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade.
//Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.
//A classe Aluno deve ter uma propriedade adicional Matricula,
//enquanto a classe Professor deve ter uma propriedade adicional Disciplina.
//Criar um método abstrato Apresentar na classe Pessoa.
//Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno,
//e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.


using System;
namespace _0611_O.O_Abstração;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informações do Aluno:");
        Console.Write("Nome: ");
        string nomeAluno = Console.ReadLine();
        Console.Write("Idade: ");
        int idadeAluno = int.Parse(Console.ReadLine());
        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();

        Aluno aluno = new Aluno(nomeAluno, idadeAluno, matricula);

        Console.WriteLine("\nInformações do Professor:");
        Console.Write("Nome: ");
        string nomeProfessor = Console.ReadLine();
        Console.Write("Idade: ");
        int idadeProfessor = int.Parse(Console.ReadLine());
        Console.Write("Disciplina: ");
        string disciplina = Console.ReadLine();

        Professor professor = new Professor(nomeProfessor, idadeProfessor, disciplina);

        Console.WriteLine("\nApresentação:");
        aluno.Apresentar();
        professor.Apresentar();
    }
}