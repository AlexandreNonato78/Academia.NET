using System;

namespace _0111ExercicioO.O._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\n===== Menu da Agenda =====");
                Console.WriteLine("1 - Adicionar Pessoa");
                Console.WriteLine("2 - Remover Pessoa");
                Console.WriteLine("3 - Buscar Pessoa");
                Console.WriteLine("4 - Imprimir Agenda");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Nome da Pessoa: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade da Pessoa: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Altura da Pessoa: ");
                        float altura = float.Parse(Console.ReadLine());

                        agenda.ArmazenaPessoa(nome, idade, altura);
                        Console.WriteLine("Pessoa adicionada à agenda.");
                        break;

                    case 2:
                        Console.Write("Nome da Pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        Console.WriteLine("Pessoa removida da agenda.");
                        break;

                    case 3:
                        Console.Write("Nome da Pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaEncontrada != null)
                            Console.WriteLine($"Pessoa encontrada - Nome: {pessoaEncontrada.Nome}, Idade: {pessoaEncontrada.Idade}, Altura: {pessoaEncontrada.Altura}");
                        else
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        break;

                    case 4:
                        agenda.ImprimeAgenda();
                        break;

                    case 5:
                        Console.WriteLine("Saindo do programa.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
