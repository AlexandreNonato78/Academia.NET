namespace _0611_O.O_Abstração4;

using System;

public abstract class ContaBancaria
{
    public double Saldo { get; protected set; }

    public ContaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public abstract void Depositar(double valor);
    public abstract void Sacar(double valor);
}

public class ContaCorrente : ContaBancaria
{
    public ContaCorrente(double saldoInicial) : base(saldoInicial)
    {
    }

    public override void Depositar(double valor)
    {
        Saldo += valor;
    }

    public override void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
        }
    }
}

public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(double saldoInicial) : base(saldoInicial)
    {
    }

    public override void Depositar(double valor)
    {
        Saldo += valor;
    }

    public override void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
        }
    }
}
