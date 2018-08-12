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
        string nomeVoto;
        int numVoto;
        List<String> candidatosList = new List<string>();

        private void campoNome_Initialized(object sender, EventArgs e)
        {
            this.campoNome.Focus();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            ListaCandidatos.Text = "";
            nome = Convert.ToString(campoNome.Text);
            num = Convert.ToInt32(campoNumero.Text);

            candidatosList.Add(nome);
            candidatosList.Add(Convert.ToString(num));

            for (int i = 0; i < candidatosList.Count; i++)
            {
                ListaCandidatos.Text += candidatosList[i] + "\n";
            }
          
            campoNome.Text = null;
            campoNumero.Text = null;
       } 

        
        private void limparLista_Click(object sender, RoutedEventArgs e)
        {
            ListaCandidatos.Text = "";

        }       

        private void btnVotar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < candidatosList.Count; i++)
            {
                //if (candidatosList.Count < 1)
                //{                   
                    if (candidatosList[i] == campoNumeroVoto.Text)
                    {
                        campoNomeVoto.Text = candidatosList[i - 1];
                    }
                //}
                //else
                //{
                //    textConfirmacaoVoto.Text = "ATENÇÃO: Não há candidatos cadastrados.";
                //}
                
                 
            }
            //get num e nome em Lista de candidatos cadastrados
            //msg de erro caso não haja candidato cadastrado com numero solicitado
        }
    }
}
