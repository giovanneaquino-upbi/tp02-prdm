// Desenvolvido por Ricardo Oliani

namespace TarefasApp;

public partial class DetalhesTarefaPage : ContentPage
{
    private Tarefa _tarefa;
    public DetalhesTarefaPage(Tarefa tarefa)
    {
        InitializeComponent();
        _tarefa = tarefa;

        tituloLabel.Text = _tarefa.Titulo;
        descricaoLabel.Text = _tarefa.Descricao;
        dataLabel.Text = _tarefa.DataCriacao.ToShortDateString();
        prioridadeLabel.Text = _tarefa.Prioridade.ToString();
    }

    private async void OnEditarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdicionarEditarTarefaPage(_tarefa));
    }

    private async void OnExcluirClicked(object sender, EventArgs e)
    {
        bool confirmado = await DisplayAlert(
            "Confirmar Exclus�o",
            $"Voc� tem certeza que deseja excluir a tarefa '{_tarefa.Titulo}'?",
            "Sim",
            "N�o");

        if (confirmado)
        {
            TarefaRepository.RemoverTarefa(_tarefa.Id);
            await Navigation.PopAsync();
        }
    }
}