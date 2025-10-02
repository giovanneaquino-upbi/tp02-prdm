// Desenvolvido por Ricardo Oliani

namespace TarefasApp;

public partial class AdicionarEditarTarefaPage : ContentPage
{
    private Tarefa _tarefa;
    private bool _isNovaTarefa;
    public AdicionarEditarTarefaPage(Tarefa tarefa)
    {
        InitializeComponent();

        prioridadePicker.ItemsSource = Enum.GetValues(typeof(Prioridade));

        if (tarefa == null)
        {
            Title = "Adicionar Nova Tarefa";
            _tarefa = new Tarefa();
            _isNovaTarefa = true;

            prioridadePicker.SelectedItem = _tarefa.Prioridade;
            dataDatePicker.Date = DateTime.Now;
        }
        else
        {
            Title = "Editar Tarefa";
            _tarefa = tarefa;
            _isNovaTarefa = false;

            tituloEntry.Text = _tarefa.Titulo;
            descricaoEditor.Text = _tarefa.Descricao;
            dataDatePicker.Date = _tarefa.DataCriacao;
            prioridadePicker.SelectedItem = _tarefa.Prioridade;
        }
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tituloEntry.Text))
        {
            await DisplayAlert("Erro", "O t�tulo da tarefa � obrigat�rio.", "OK");
            return;
        }

        _tarefa.Titulo = tituloEntry.Text;
        _tarefa.Descricao = descricaoEditor.Text;
        _tarefa.DataCriacao = dataDatePicker.Date;
        _tarefa.Prioridade = (Prioridade)prioridadePicker.SelectedItem;

        if (_isNovaTarefa)
        {
            TarefaRepository.AdicionarTarefa(_tarefa);
        }
        else
        {
            TarefaRepository.AtualizarTarefa(_tarefa);

            var navigationStack = Navigation.NavigationStack;

            if (navigationStack.Count > 1)
            {
                var detalhesPage = navigationStack[navigationStack.Count - 2];
                Navigation.RemovePage(detalhesPage);
            }
        }

        await Navigation.PopAsync();
    }
}