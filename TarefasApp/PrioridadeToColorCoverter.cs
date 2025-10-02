// Desenvolvido por Ricardo Oliani

using System.Globalization;

namespace TarefasApp
{
    class PrioridadeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Prioridade prioridade)
            {
                switch (prioridade)
                {
                    case Prioridade.Alta:
                        return Colors.Red;
                    case Prioridade.Media:
                        return Colors.Yellow;
                    case Prioridade.Baixa:
                        return Colors.Green;
                }
            }

            return Colors.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
