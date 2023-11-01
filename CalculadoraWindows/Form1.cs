using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindows
{
    public partial class Form1 : Form
    {
        int numero1;
        string ultimoOp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // Limpar todas as informações:
            txbTela.Clear();
            txbAux.Clear();
        }
        private void Numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando o evento:
            var botao = (Button)sender;
            txbTela.Text += botao.Text;
        }
        private void Operador_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando o evento:
            var botao = (Button)sender;
            if (txbTela.Text != "")
            {
                numero1 = int.Parse(txbTela.Text);
                txbTela.Clear();
                txbAux.Text = numero1.ToString() + botao.Text;
                ultimoOp = botao.Text;
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Definir a função dos operadores:
            switch (ultimoOp)
            {
                case "+":
                    txbAux.Clear();
                    txbTela.Text = (numero1 + int.Parse(txbTela.Text)).ToString();
                    break;

                case "-":
                    txbAux.Clear();
                    txbTela.Text = (numero1 - int.Parse(txbTela.Text)).ToString();
                    break;

                case "X":
                    txbAux.Clear();
                    txbTela.Text = (numero1 * int.Parse(txbTela.Text)).ToString();
                    break;

                case "÷":
                    // Impedir que um número seja dividido por 0:
                    if (int.Parse(txbTela.Text) <= 0)
                    {
                        MessageBox.Show("Impossível dividir por 0!");
                        txbTela.Clear();
                        txbAux.Clear();
                    }
                    else
                    {
                        txbAux.Clear();
                        txbTela.Text = (numero1 / int.Parse(txbTela.Text)).ToString();
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
