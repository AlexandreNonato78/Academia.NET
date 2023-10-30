using System;

namespace _2610ExercicioOrient.Obj._6
{
    class Tarefa
    {
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }
    }

    class GerenciadorDeTarefas

    {
        // Atributos da classe
        private List<Tarefa> tarefas;

        // Construtor
        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        // Método para adicionar uma tarefa
        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        // Método para remover uma tarefa
        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefa = tarefas.Find(t => t.Descricao == descricao);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        // Método para listar todas as tarefas
        public void ListarTarefas()
        {
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine("Descrição: " + tarefa.Descricao);
                Console.WriteLine("Data de Vencimento: " + tarefa.DataVencimento.ToString("dd/MM/yyyy"));
                Console.WriteLine("==============================");
            }
        }

        // Método para verificar se a tarefa deve ser executada no dia de hoje
        public List<Tarefa> TarefasParaHoje()
        {
            DateTime hoje = DateTime.Now.Date;
            return tarefas.FindAll(t => t.DataVencimento.Date == hoje);
        }
    }
}
