// Desenvolvido por Ricardo Oliani

namespace TarefasApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            tarefasCollectionView.ItemsSource = TarefaRepository.Tarefas;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            tarefasCollectionView.ItemsSource = null;
            var tarefasOrdenadas = TarefaRepository.Tarefas.OrderByDescending(t => t.Prioridade).ToList();
            tarefasCollectionView.ItemsSource = tarefasOrdenadas;
        }

        private async void OnAdicionarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdicionarEditarTarefaPage(null));
        }

        private async void OnTarefaSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Tarefa tarefaSelecionada)
            {
                await Navigation.PushAsync(new DetalhesTarefaPage(tarefaSelecionada));

                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}
