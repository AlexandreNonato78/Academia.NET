//6 - Crie uma classe "ContaBancaria" com propriedades para "Saldo" e métodos "Depositar" e "Sacar".

namespace _0611_O.O_Abstração6;
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o saldo inicial da conta bancária: ");
        double saldoInicial = double.Parse(Console.ReadLine());

        ContaBancaria conta = new ContaBancaria(saldoInicial);

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Mostrar Saldo");
            Console.WriteLine("4 - Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite o valor para depositar: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                case 2:
                    Console.Write("Digite o valor para sacar: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case 3:
                    conta.MostrarSaldo();
                    break;
                case 4:
                    Console.WriteLine("Encerrando o programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
