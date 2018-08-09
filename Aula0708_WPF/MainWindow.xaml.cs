using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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


        string operador;

        private void btnNumerador(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)
            Tela.Content = Tela.Content + operador +
        }

        //private void btn1_Click(object sender, RoutedEventArgs e)
        //{
        //    Tela.Content += "1";
        //}

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
            operador = "-";
            Tela.Content += "-";
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            operador = "+";
            Tela.Content += "+";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operador = "-";
            Tela.Content += "/";
        }

        private void btnMultiplica_Click(object sender, RoutedEventArgs e)
        {
            operador = "*";
            Tela.Content += "*";
        }

        private void btnPonto_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += ".";
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
