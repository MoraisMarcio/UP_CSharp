﻿using System;
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
using System.Windows.Shapes;

namespace Aula2808_WPF.Views
{
    /// <summary>
    /// Lógica interna para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCarregarTela1_Click(object sender, RoutedEventArgs e)
        {
            Tela1 minhaTela1 = new Tela1();
            minhaTela1.Show();
        }

        private void btnCarregarTela2_Click(object sender, RoutedEventArgs e)
        {
            Tela2 minhaTela2 = new Tela2();
            minhaTela2.Show();
        }
    }
}
