// Desenvolvido por Ricardo Oliani

namespace TarefasApp
{
    public partial class App : Application
    {
        public App()
        {
            System.Diagnostics.Debug.WriteLine("App inicializando...");
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
