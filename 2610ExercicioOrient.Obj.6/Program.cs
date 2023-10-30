using System;
//6 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descrição, data de vencimento).
//Implemente um construtor e métodos para adicionar, remover e listar tarefas.
//Adicione um método para verificar se a tarefa deverá ser executada no dia de hoje. 


namespace _2610ExercicioOrient.Obj._6
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            while (true)
            {
                Console.WriteLine("===== Menu do Gerenciador de Tarefas =====");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Remover Tarefa");
                Console.WriteLine("3 - Listar Tarefas");
                Console.WriteLine("4 - Tarefas para Hoje");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Descrição da Tarefa: ");
                        string descricao = Console.ReadLine();
                        Console.Write("Data de Vencimento (dd/mm/aaaa): ");
                        if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataVencimento))
                        {
                            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
                            gerenciador.AdicionarTarefa(novaTarefa);
                            Console.WriteLine("Tarefa adicionada com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Data inválida. Certifique-se de inserir a data no formato dd/mm/aaaa.");
                        }
                        break;

                    case 2:
                        Console.Write("Descrição da Tarefa a ser removida: ");
                        string descricaoRemover = Console.ReadLine();
                        gerenciador.RemoverTarefa(descricaoRemover);
                        break;

                    case 3:
                        gerenciador.ListarTarefas();
                        break;

                    case 4:
                        Console.WriteLine("Tarefas para Hoje:");
                        List<Tarefa> tarefasHoje = gerenciador.TarefasParaHoje();
                        foreach (Tarefa tarefa in tarefasHoje)
                        {
                            Console.WriteLine("Descrição: " + tarefa.Descricao);
                            Console.WriteLine("Data de Vencimento: " + tarefa.DataVencimento.ToString("dd/MM/yyyy"));
                            Console.WriteLine("==============================");
                        }
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
