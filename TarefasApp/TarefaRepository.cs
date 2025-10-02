// Desenvolvido por Ricardo Oliani

using System.Collections.ObjectModel;

namespace TarefasApp
{
    public static class TarefaRepository
    {
        public static ObservableCollection<Tarefa> Tarefas { get; set; } = new ObservableCollection<Tarefa>();

        public static void AdicionarTarefa(Tarefa tarefa)
        {
            Tarefas.Add(tarefa);
        }

        public static void RemoverTarefa(Guid id)
        {
            var tarefa = Tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa != null)
            {
                Tarefas.Remove(tarefa);
            }
        }

        public static void AtualizarTarefa(Tarefa tarefaAtualizada)
        {
            var tarefa = Tarefas.FirstOrDefault(t => t.Id == tarefaAtualizada.Id);
            if (tarefa != null)
            {
                tarefa.Titulo = tarefaAtualizada.Titulo;
                tarefa.Descricao = tarefaAtualizada.Descricao;
                tarefa.DataCriacao = tarefaAtualizada.DataCriacao;
                tarefa.Prioridade = tarefaAtualizada.Prioridade;
            }
        }
    }
}
