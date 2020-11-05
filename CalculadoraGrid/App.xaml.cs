using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CalculadoraGrid
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void numeroButton_Click(object sender, RoutedEventArgs e)
        {
            string numero = (sender as Button).Tag.ToString();

            ((TextBlock)((MainWindow)MainWindow).FindName("calculadoraTextBlock")).Text += numero;
        }
    }
}
