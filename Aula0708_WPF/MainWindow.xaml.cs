using System;
using System.Windows;
using System.Windows.Controls;


namespace Aula0708_WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //string label;

        string operador;
        int a = 0;
        bool validar = false;

        private void btnNumerador(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            Tela.Text = Tela.Text + bt.Content;
        }   

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(Tela.Text);
                Label.Content = Convert.ToString(a) + "-";
                Tela.Text = "";
                operador = "-";
            }
            else
            {
                Label.Content = Tela.Text + btnMenos.Content;
                a = Convert.ToInt32(Tela.Text);
                Tela.Text = "";
                operador = "-";
                validar = true;
            }
           
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(Tela.Text);
                Label.Content = Convert.ToString(a) + "+";
                Tela.Text = "";
                operador = "+";
            }
            else
            {
                Label.Content = Tela.Text + btnMais.Content;
                a = Convert.ToInt32(Tela.Text);
                Tela.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(Tela.Text);
                Label.Content = Convert.ToString(a) + "/";
                Tela.Text = "";
                operador = "/";
            }
            else
            {
                Label.Content = Tela.Text + btnDivide.Content;
                a = Convert.ToInt32(Tela.Text);
                Tela.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btnMultiplica_Click(object sender, RoutedEventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(Tela.Text);
                Label.Content = Convert.ToString(a) + "*";
                Tela.Text = "";
                operador = "*";
            }
            else
            {
                Label.Content = Tela.Text + btnMultiplica.Content;
                a = Convert.ToInt32(Tela.Text);
                Tela.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btnPonto_Click(object sender, RoutedEventArgs e)
        {
            Tela.Text += ".";
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "+")
            {
                Label.Content = Label.Content + Tela.Text + "=";
                Tela.Text = Convert.ToString(a + Convert.ToInt32(Tela.Text));
            }
            else if (operador == "-")
            {
                Label.Content = Label.Content + Tela.Text + "=";
                Tela.Text = Convert.ToString(a - Convert.ToInt32(Tela.Text));
            }
            else if (operador == "/")
            {
                Label.Content = Label.Content + Tela.Text + "=";
                Tela.Text = Convert.ToString(a / Convert.ToInt32(Tela.Text));
            }
            else if (operador == "*")
            {
                Label.Content = Label.Content + Tela.Text + "=";
                Tela.Text = Convert.ToString(a * Convert.ToInt32(Tela.Text));
            }

        }

    }
}
