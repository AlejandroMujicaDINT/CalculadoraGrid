
using System.Windows;
using System.Windows.Controls;


namespace CalculadoraGrid
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void numeroButton_Click(object sender, RoutedEventArgs e)
        {
            string numero = (sender as Button).Tag.ToString();

            calculadoraTextBlock.Text += numero;
        }
    }
}
