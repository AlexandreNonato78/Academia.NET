//11 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade".
//Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10) e
//outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a velocidade negativa).
using System;

namespace _0111ExercicioO.O._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Console.WriteLine("===== Cadastro de Carro =====");
            do
            {
                Console.Write("Modelo do Carro: ");
                carro.Modelo = Console.ReadLine();
            } while (string.IsNullOrEmpty(carro.Modelo));

            Console.Write("Ano do Carro: ");
            if (int.TryParse(Console.ReadLine(), out int ano))
            {
                carro.Ano = ano;
            }
            else
            {
                Console.WriteLine("Ano inválido.");
                return;
            }

            Console.Write("Velocidade Inicial do Carro: ");
            if (int.TryParse(Console.ReadLine(), out int velocidade))
            {
                carro.Velocidade = velocidade;
            }
            else
            {
                Console.WriteLine("Velocidade inicial inválida.");
                return;
            }

            Console.WriteLine("\n===== Operações com o Carro =====");
            Console.WriteLine("1 - Acelerar");
            Console.WriteLine("2 - Frear");
            Console.WriteLine("3 - Sair");

            while (true)
            {
                Console.Write("Escolha uma operação: ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        carro.Acelerar();
                        Console.WriteLine("Carro acelerado. Nova velocidade: " + carro.Velocidade);
                        break;

                    case 2:
                        carro.Frear();
                        Console.WriteLine("Carro freado. Nova velocidade: " + carro.Velocidade);
                        break;

                    case 3:
                        Console.WriteLine("Saindo do programa.");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
