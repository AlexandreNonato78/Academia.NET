using System;

namespace _0611_O.O_Abstração5;

public abstract class Produto
{
    public string Nome { get; protected set; }
    public decimal Preco { get; protected set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public abstract decimal CalcularDesconto();
}

public class Livro : Produto
{
    public Livro(string nome, decimal preco) : base(nome, preco)
    {
    }

    public override decimal CalcularDesconto()
    {
        return Preco * 0.05m;
    }
}

public class Eletronico : Produto
{
    public Eletronico(string nome, decimal preco) : base(nome, preco)
    {
    }

    public override decimal CalcularDesconto()
    {
        return Preco * 0.125m;
    }
}

