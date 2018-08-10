using System.Windows;

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

        int operador;
        float n1, n2; 

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += "0";
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            operador = 1;
            n1 = float.Parse(Tela.Content.ToString());
            Tela.Content = "-";
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            operador = 2;           
            n1 = float.Parse(Tela.Content.ToString());
            Tela.Content += "+";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operador = 3;
            n1 = float.Parse(Tela.Content.ToString());
            Tela.Content = "/";
        }

        private void btnMultiplica_Click(object sender, RoutedEventArgs e)
        {
            operador = 4;
            n1 = float.Parse(Tela.Content.ToString());
            Tela.Content = "*";
        }

        private void btnPonto_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += ".";
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            switch (operador)
            {
                case 1:
                    Tela.Content = (n1 - n2).ToString();
                    break;

                case 2:
                    Tela.Content = (n1 + n2).ToString();
                    break;

                case 3:
                    Tela.Content = (n1 / n2).ToString();
                    break;

                case 4:
                    Tela.Content = (n1 * n2).ToString();
                    break;

            }
        }

        
    }
}
