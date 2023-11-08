//4 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar".
//Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.

namespace _0611_O.O_Abstração4;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o saldo inicial da Conta Corrente: ");
        double saldoInicialContaCorrente = double.Parse(Console.ReadLine());
        ContaCorrente contaCorrente = new ContaCorrente(saldoInicialContaCorrente);

        Console.Write("Digite o saldo inicial da Conta Poupança: ");
        double saldoInicialContaPoupanca = double.Parse(Console.ReadLine());
        ContaPoupanca contaPoupanca = new ContaPoupanca(saldoInicialContaPoupanca);

        Console.WriteLine("\nSaldo inicial da Conta Corrente: " + contaCorrente.Saldo);
        Console.WriteLine("Saldo inicial da Conta Poupança: " + contaPoupanca.Saldo);

        Console.Write("\nDigite o valor a depositar na Conta Corrente: ");
        double depositoContaCorrente = double.Parse(Console.ReadLine());
        contaCorrente.Depositar(depositoContaCorrente);

        Console.Write("Digite o valor a sacar da Conta Corrente: ");
        double saqueContaCorrente = double.Parse(Console.ReadLine());
        contaCorrente.Sacar(saqueContaCorrente);

        Console.Write("\nDigite o valor a depositar na Conta Poupança: ");
        double depositoContaPoupanca = double.Parse(Console.ReadLine());
        contaPoupanca.Depositar(depositoContaPoupanca);

        Console.Write("Digite o valor a sacar da Conta Poupança: ");
        double saqueContaPoupanca = double.Parse(Console.ReadLine());
        contaPoupanca.Sacar(saqueContaPoupanca);

        Console.WriteLine("\nSaldo atual da Conta Corrente: " + contaCorrente.Saldo);
        Console.WriteLine("Saldo atual da Conta Poupança: " + contaPoupanca.Saldo);
    }
}