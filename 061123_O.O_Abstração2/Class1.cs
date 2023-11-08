using System;
public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public abstract void Dirigir();
}

public class Carro : Veiculo
{
    public int QuantidadeDePortas { get; set; }

    public Carro(string marca, string modelo, int quantidadeDePortas) : base(marca, modelo)
    {
        QuantidadeDePortas = quantidadeDePortas;
    }

    public override void Dirigir()
    {
        Console.WriteLine($"Dirigindo o {Marca} {Modelo} com {QuantidadeDePortas} portas.");
    }
}

public class Moto : Veiculo
{
    public int Cilindradas { get; set; }

    public Moto(string marca, string modelo, int cilindradas) : base(marca, modelo)
    {
        Cilindradas = cilindradas;
    }

    public override void Dirigir()
    {
        Console.WriteLine($"Dirigindo a {Marca} {Modelo} com {Cilindradas} cilindradas.");
    }
}