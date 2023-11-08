using System;


namespace _0611_O.O_Abstração;

public abstract class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public abstract void Apresentar();
}

public class Aluno : Pessoa
{
    public string Matricula { get; set; }

    public Aluno(string nome, int idade, string matricula) : base(nome, idade)
    {
        Matricula = matricula;
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Aluno: Nome - {Nome}, Idade - {Idade}, Matrícula - {Matricula}");
    }
}

public class Professor : Pessoa
{
    public string Disciplina { get; set; }

    public Professor(string nome, int idade, string disciplina) : base(nome, idade)
    {
        Disciplina = disciplina;
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Professor: Nome - {Nome}, Idade - {Idade}, Disciplina - {Disciplina}");
    }
}