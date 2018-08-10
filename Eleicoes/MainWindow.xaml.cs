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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Eleicoes
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

        string nome;
        int num;
        List<String> candidatosList = new List<string>();    

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            nome = Convert.ToString(campoNome.Text);
            num = Convert.ToInt32(campoNumero.Text);

            candidatosList.Add(nome);
            candidatosList.Add(Convert.ToString(num));

       } 

        
        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= candidatosList.Count; i++)
            {
                ListaCandidatos.Text = candidatosList[i];
            }
        }
    }
}
