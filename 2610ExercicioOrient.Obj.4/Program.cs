//4 - Crie uma classe AgendaTelefônica com atributos para armazenar contatos(nome, telefone, e-mail).
//Implemente um construtor e métodos para adicionar numa lista, remover e buscar contatos.

using System;

namespace ExercicioAgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefônica agenda = new AgendaTelefônica();

            while (true)
            {
                Console.WriteLine("===== Menu da Agenda Telefônica =====");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Remover Contato");
                Console.WriteLine("3 - Buscar Contato");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Nome do Contato: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone do Contato: ");
                        string telefone = Console.ReadLine();
                        Console.Write("E-mail do Contato: ");
                        string email = Console.ReadLine();

                        Contato novoContato = new Contato(nome, telefone, email);
                        agenda.AdicionarContato(novoContato);
                        Console.WriteLine("Contato adicionado com sucesso.");
                        break;

                    case 2:
                        Console.Write("Nome do Contato a ser removido: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContato(nomeRemover);
                        break;

                    case 3:
                        Console.Write("Nome do Contato a ser buscado: ");
                        string nomeBuscar = Console.ReadLine();
                        Contato contatoEncontrado = agenda.BuscarContato(nomeBuscar);
                        if (contatoEncontrado != null)
                        {
                            Console.WriteLine("Contato Encontrado:");
                            Console.WriteLine("Nome: " + contatoEncontrado.Nome);
                            Console.WriteLine("Telefone: " + contatoEncontrado.Telefone);
                            Console.WriteLine("E-mail: " + contatoEncontrado.Email);
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saindo da Agenda Telefônica.");
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
