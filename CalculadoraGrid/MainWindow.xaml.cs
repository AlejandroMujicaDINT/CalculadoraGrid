
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

            CrearBotones();
            CrearBotonCero();
        }

        private void CrearBotones()
        {
            Button boton;
            int numero = 1;
            for (int i = 1; i < CalculadoraGrid.RowDefinitions.Count - 1; i++)
            {
                for (int j = 0; j < CalculadoraGrid.ColumnDefinitions.Count; j++)
                {
                    boton = new Button();
                    TextBlock text = new TextBlock();
                    text.Text = numero.ToString();
                    Viewbox vb = new Viewbox();
                    vb.Child = text;
                    boton.Content = vb;
                    boton.Tag = numero;
                    boton.Margin = new Thickness(5);
                    boton.Style = (Style)Application.Current.Resources["botonesEvent"];

                    numero++;

                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);

                    CalculadoraGrid.Children.Add(boton);
                }
            }
        }

        private void CrearBotonCero()
        {
            Button boton = new Button();
            TextBlock text = new TextBlock();
            text.Text = 0.ToString();
            Viewbox vb = new Viewbox();
            vb.Child = text;
            boton.Content = vb;
            boton.Tag = 0;
            boton.Margin = new Thickness(5);
            boton.Style = (Style)Application.Current.Resources["botonesEvent"];
            boton.FontSize = 20;

            Grid.SetRow(boton, 4);
            Grid.SetColumn(boton, 0);
            Grid.SetColumnSpan(boton, 3);

            CalculadoraGrid.Children.Add(boton);
        }
    }
}
