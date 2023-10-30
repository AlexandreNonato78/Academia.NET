﻿namespace _2_Padel;

public class Pessoa
{
    public string Nome { set; get; }
    public string Email { set; get; }
    public DateOnly DataNascimento { set; get; }

    public Pessoa(string nome, string email, DateOnly data)
    {
        this.Nome = nome;
        this.Email = email;
        this.DataNascimento = data;
    }

    //sobrecarga do construtor, um exemplo de polimorfismo
    public Pessoa(string nome, string email)
    {
        this.Nome = nome;
        this.Email = email;
    }

    public string idade()
    {
        //pegar a data atual, no mínimo o ano
        //pegar o ano de nascimento

        //retornar o ano atual - ano de nascimento
        return "";
    }

    public string sobrenome()
    {
        string[] vetor = this.Nome.Split();
        return vetor[vetor.Length - 1];
    }

}