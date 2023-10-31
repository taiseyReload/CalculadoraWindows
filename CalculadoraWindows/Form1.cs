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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }
        private void Numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando o evento:
            var botao = (Button)sender;
            txbTela.Text += botao.Text;
        }
    }
}
