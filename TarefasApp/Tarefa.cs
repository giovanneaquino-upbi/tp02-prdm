// Desenvolvido por Ricardo Oliani

namespace TarefasApp
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public Prioridade Prioridade { get; set; }

        public Tarefa()
        {
            Id = Guid.NewGuid();
            Titulo = "";
            Descricao = "";
            DataCriacao = DateTime.Now;
            Prioridade = Prioridade.Baixa;
        }
    }

    public enum Prioridade
    {
        Baixa,
        Media,
        Alta
    }
}
