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

namespace CalculadoraWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string UltimoBtnClicado = null;
        double Numerador = 0;
        double Denominador = 0;
        string Operador = null;


        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (CalculoExibicao.Text != "0")
            {
                CalculoExibicao.Text = CalculoExibicao.Text + "0";
            }

            if (UltimoBtnClicado == "+" || UltimoBtnClicado == "-" || UltimoBtnClicado == "*" || UltimoBtnClicado == "/")
            {
                CalculoExibicao.Text = "0";
            }
            UltimoBtnClicado = "0";

        }

        private void Numeros(string numero)
        {
            if (UltimoBtnClicado == "+" || UltimoBtnClicado == "-" || UltimoBtnClicado == "*" || UltimoBtnClicado == "/" || CalculoExibicao.Text == "0")
            {
                CalculoExibicao.Text = numero;
            }
            else
            {
                CalculoExibicao.Text = CalculoExibicao.Text + numero;
            }
            UltimoBtnClicado = numero;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Numeros("1");
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Numeros("2");

        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            Numeros("3");
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            Numeros("4");
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            Numeros("5");
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            Numeros("6");
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            Numeros("7");
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            Numeros("8");
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            Numeros("9");
        }

        private void BtnNegativar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CalculoExibicao.Text))
            {
                return;
            }

            var numero = double.Parse(CalculoExibicao.Text);

            if (numero != 0)
            {
                CalculoExibicao.Text = (numero * -1).ToString();
            }

        }
        private void BtnVirgula_Click(object sender, RoutedEventArgs e)
        {

            if (!CalculoExibicao.Text.Contains(","))
            {
                CalculoExibicao.Text = CalculoExibicao.Text + ",";
                UltimoBtnClicado = ",";
            }

        }

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            CalculoExibicao.Text = "0";
            CalculoAuxiliar.Content = string.Empty;
            Operador = null;
            Numerador = 0;
            Denominador = 0;
        }

        private void BtnApagar_Click(object sender, RoutedEventArgs e)
        {
            if (CalculoExibicao.Text.Length > 0)
            {
                CalculoExibicao.Text = CalculoExibicao.Text.Substring(0, CalculoExibicao.Text.Length - 1);
            }

            if (CalculoExibicao.Text.Length == 0)
            {
                CalculoExibicao.Text = "0";
            }
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            CalculoExibicao.Text = "0";

        }

        private void Operadores(string operador)
        {
            Igual();
            UltimoBtnClicado = operador;
            CalculoAuxiliar.Content = CalculoExibicao.Text + operador;
            Operador = operador;
            Numerador = double.Parse(CalculoExibicao.Text);
        }

        private void BtnSoma_Click(object sender, RoutedEventArgs e)
        {
            Operadores("+");
        }

        private void BtnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            Operadores("-");
        }

        private void BtnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            Operadores("*");
        }

        private void BtnDivisao_Click(object sender, RoutedEventArgs e)
        {
            Operadores("/");
        }

        private void BtnIgual_Click(object sender, RoutedEventArgs e)
        {
            Igual();
        }

        private void Igual()
        {
            if (string.IsNullOrEmpty(Operador))
            {
                return;
            }

            UltimoBtnClicado = "=";
            CalculoAuxiliar.Content += CalculoExibicao.Text + "=";
            Denominador = double.Parse(CalculoExibicao.Text);

            double ContaFinal = 0;

            if (Operador == "+")
            {
                ContaFinal = Numerador + Denominador;
            }
            else if (Operador == "-")
            {
                ContaFinal = Numerador - Denominador;
            }
            else if (Operador == "*")
            {
                ContaFinal = Numerador * Denominador;
            }
            else if (Operador == "/")
            {
                ContaFinal = Numerador / Denominador;
            }
            CalculoExibicao.Text = ContaFinal.ToString();

            Operador = null;
            Numerador = 0;
            Denominador = 0;
        }

    }
}
