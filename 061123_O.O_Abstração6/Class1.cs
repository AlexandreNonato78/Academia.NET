namespace _0611_O.O_Abstração6;
using System;


public class ContaBancaria
{
    public double Saldo { get; private set; }

    public ContaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} efetuado com sucesso.");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} efetuado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo atual: {Saldo:C}");
    }
}
