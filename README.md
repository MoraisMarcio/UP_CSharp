# UP_CSharp
Aulas de C#

Repositório para códigos desenvolvidos nas aulas de C#

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

        string label;

        string[] operadores = { "-", "+", "/", "*" };

        //string operador;

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            label += "1";
            Tela.Content += "1";        
            
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            //   label += 2;
            label += "2";
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
            //operador += "-";
            Tela.Content += "-";
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            //operador += "+";
            Tela.Content += "+";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            //operador += "/";
            Tela.Content += "/";
        }

        private void btnMultiplica_Click(object sender, RoutedEventArgs e)
        {
            //operador += "*";
            Tela.Content += "*";
        }

        private void btnPonto_Click(object sender, RoutedEventArgs e)
        {
            Tela.Content += ".";
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            string[] numeros = label.Split(operadores, StringSplitOptions.RemoveEmptyEntries);
            Tela.Content = "Funcionou:"+ numeros;
            // Double.Parse(numeros);
        }
    }
}





<Window x:Class="Aula0708_WPF.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Aula0708_WPF"
        mc:Ignorable="d"
        Title="MainWindow" Height="350" Width="525">
    <Grid HorizontalAlignment="Center" VerticalAlignment="Center">
        <Button x:Name="btn7" Content="7" HorizontalAlignment="Left" Margin="-53,-65,0,0" VerticalAlignment="Top" Width="24" Click="btn7_Click"/>
        <Button x:Name="btn8" Content="8" HorizontalAlignment="Left" Margin="-24,-65,0,0" VerticalAlignment="Top" Width="24" Click="btn8_Click"/>
        <Button x:Name="btn9" Content="9" HorizontalAlignment="Left" Margin="5,-65,-29,0" VerticalAlignment="Top" Width="24" Click="btn9_Click"/>
        <Button x:Name="btn4" Content="4" HorizontalAlignment="Left" Margin="-53,-40,0,0" VerticalAlignment="Top" Width="24" Click="btn4_Click"/>
        <Button x:Name="btn5" Content="5" HorizontalAlignment="Left" Margin="-24,-40,0,0" VerticalAlignment="Top" Width="24" Click="btn5_Click"/>
        <Button x:Name="btn6" Content="6" HorizontalAlignment="Left" Margin="5,-40,-29,0" VerticalAlignment="Top" Width="24" Click="btn6_Click"/>
        <Button x:Name="btn1" Content="1" HorizontalAlignment="Left" Margin="-53,-15,0,-5" Width="24" Height="20" VerticalAlignment="Top" Click="btn1_Click"/>
        <Button x:Name="btn2" Content="2" HorizontalAlignment="Left" Margin="-24,-15,0,-5" VerticalAlignment="Top" Width="24" Click="btn2_Click"/>
        <Button x:Name="btn3" Content="3" HorizontalAlignment="Left" Margin="5,-15,-29,-5" VerticalAlignment="Top" Width="24" Click="btn3_Click"/>
        <Button x:Name="btn0" Content="0" HorizontalAlignment="Left" Margin="-53,10,0,-30" VerticalAlignment="Top" Width="24" Click="btn0_Click"/>
        <Button x:Name="btnPonto" Content="." HorizontalAlignment="Left" Margin="-24,10,0,-30" VerticalAlignment="Top" Width="24" Click="btnPonto_Click"/>
        <Button x:Name="btnMenos" Content="-" HorizontalAlignment="Left" Margin="34,-65,-58,0" VerticalAlignment="Top" Width="24" Click="btnMenos_Click"/>
        <Button x:Name="btnMais" Content="+" HorizontalAlignment="Left" Margin="34,-40,-58,0" VerticalAlignment="Top" Width="24" Click="btnMais_Click"/>
        <Button x:Name="btnDivide" Content="/" HorizontalAlignment="Left" Margin="34,-15,-58,-5" VerticalAlignment="Top" Width="24" Click="btnDivide_Click"/>
        <Button x:Name="btnMultiplica" Content="*" HorizontalAlignment="Left" Margin="34,10,-58,-30" VerticalAlignment="Top" Width="24" Click="btnMultiplica_Click"/>
        <Button x:Name="btnResultado" Content="=" HorizontalAlignment="Left" Margin="5,10,-29,-30" VerticalAlignment="Top" Width="24" Click="btnResultado_Click"/>
        <Label x:Name="Tela" Content="" HorizontalAlignment="Left" Margin="-53,-96,-58,0" VerticalAlignment="Top" Width="111" BorderBrush="Black" BorderThickness="1"/>


    </Grid>
</Window>
